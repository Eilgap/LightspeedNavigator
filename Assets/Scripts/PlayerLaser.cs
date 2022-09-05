using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public float speed;
    private Animator anim;
    public Vector3 d;
    bool stop = false;
    public AudioSource boom;

    void Start()
    {
        d = Vector3.zero;
        d.x += 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
        anim = GetComponent<Animator>();
        boom = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(stop == false)
        {
            d = Vector3.zero;
            d.x += 1.0f;
            transform.Translate(d * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(d * 0);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        boom.Play();
        switch(collision.gameObject.tag)
        {
            case "Asteroid":
                break;
            case "Enemy":
                Destroy(collision.gameObject);
                anim.SetTrigger("LaserHit");
                transform.Translate(d * 0);
                stop = true;
                break;
            default:
                break;
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
