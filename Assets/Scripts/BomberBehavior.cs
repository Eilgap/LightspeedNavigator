using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberBehavior : MonoBehaviour
{
    public float speed;
    public float t;
    private Scoring s;
    private Animator anim;
    public EnemyLaser pew;
    public AudioSource pewPew;
    public Vector3 playPos;
    public float shotTimer;
    //public EnemyLaser pew;
    // Start is called before the first frame update
    void Start()
    {
        shotTimer = Time.time;
        s = FindObjectOfType<Scoring>();
        Vector3 d = Vector3.zero;
        d.x -= 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        playPos = GameObject.Find("CharacterShip").transform.position;
        Vector3 d = Vector3.zero;
        d.x -= 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
        if(transform.position.x < -50)
        {
            Destroy(gameObject);
        }
        if(Time.time - shotTimer >= 1f && !(transform.position.x < -12))
        {
            Shoot();
            shotTimer = Time.time;
        }
        if(transform.position.x < playPos.x - 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Asteroid":
                break;
            case "Laser":
                Destroy(collision.gameObject, .7f);
                s.RaiseScore(100);
                break;
            case "Enemy":
                Destroy(collision.gameObject);
                break;
            default:
                break;
        }
    }

    void Shoot()
    {
        Vector3 pos = gameObject.transform.position;
        if(playPos.y > pos.y)
        {
            pos.y += 1.1f;
        }
        else if(playPos.y < pos.y)
        {
            pos.y -=1.1f;
        }
        pos.x -= 1.5f;
        Instantiate(pew, pos, Quaternion.identity);
        pewPew.Play();
    }
}
