using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{   
    public float speed;
    private Scoring s;
    private Animator anim;
    private bool shotLimit = true;
    public PlayerLaser pew;

    void Start()
    {
        s = FindObjectOfType<Scoring>();
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        Vector3 d = Vector3.zero;
        if(transform.position.y < 11  && transform.position.y > -11)
        {
            if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                d.y += 1.0f;
            }
            if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                d.y -= 1.0f;
            }
        }
        else if(transform.position.y > 11)
        {
            d.y -= 1.0f;
        }
        else if(transform.position.y < -11)
        {
            d.y += 1.0f;
        }
        transform.Translate(d * speed * Time.deltaTime);
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey(KeyCode.Space))
        {
            if(shotLimit)
            {
                Shoot();
            }
            shotLimit = false;
        }
        else
        {
            shotLimit = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("PlayerHit");
        switch(collision.gameObject.tag)
        {
            case "Asteroid":
                s.Death();
                break;
            case "Laser":
                Destroy(collision.gameObject);
                s.Death();
                break;
            case "Enemy":
                Destroy(collision.gameObject);
                s.Death();
                break;
            default:
                break;
        }
    }

    private void Shoot()
    {
        Vector3 pos = gameObject.transform.position;
        pos.x += 1.7f;
        Instantiate(pew, pos, Quaternion.identity);
    }
}
