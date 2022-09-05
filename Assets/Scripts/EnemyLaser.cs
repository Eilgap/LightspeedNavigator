using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public bool stop = false;
    public Vector3 d;
    public Vector3 t;
    public Vector3 p;
    public float speed;
    public float dis;
    public Rigidbody2D self;
    // Start is called before the first frame update
    void Start()
    {
        d = Vector3.zero;
        p = Vector3.zero;
        d = gameObject.transform.position;
        p = GameObject.Find("CharacterShip").transform.position;
        t = p - d;
        //transform.Translate(t * speed * Time.deltaTime);

        //t = t.normalized * Time.deltaTime * speed;
        //dis = Vector3.Distance(transform.position, p);
        self.velocity = new Vector3(t.x, t.y, 0).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(stop)
        {
            transform.Translate(t * 0);
        }
        /*else 
        {
            transform.position = transform.position + Vector3.ClampMagnitude(t, dis);
        }*/
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Asteroid":
                break;
            case "Enemy":
                Destroy(collision.gameObject);
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
