using UnityEngine;
using System.Collections;
using System.Threading;
using System;

public class PlayerMovement : MonoBehaviour
{   
    public float speed;
    private Scoring s;
    private Animator anim;
    private bool shotLimit = true;
    public PlayerLaser pew;
    public AudioSource pewPew;
    public AudioSource boom;
    public float deathTimer = 0;
    public bool d2 = false;

    void Start()
    {
        s = FindObjectOfType<Scoring>();
        anim = GetComponent<Animator>();
        //pewPew = GetComponent<AudioSource>();
        //boom = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        Vector3 d = Vector3.zero;
        if(transform.position.y < 11  && transform.position.y > -11 && !d2)
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

        if(Time.time - deathTimer >= .7f && d2)
        {
            deathTimer = 0;
            d2 = false;
            s.Death();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("PlayerHit");
        deathTimer = Time.time;
        d2 = true;
        boom.Play();
        switch(collision.gameObject.tag)
        {
            case "Asteroid":
                //s.Death();
                break;
            case "Laser":
                Destroy(collision.gameObject);
                //s.Death();
                break;
            case "Enemy":
                Destroy(collision.gameObject);
                //s.Death();
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
        pewPew.Play();
    }
}
