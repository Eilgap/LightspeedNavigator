using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 d = Vector3.zero;
        d.x -= 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 d = Vector3.zero;
        d.x -= 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
        if(transform.position.x < -50)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Player":
                Destroy(collision.gameObject, .70f);
                break;
            case "Asteroid":
                break;
            case "Laser":
                Destroy(collision.gameObject);
                break;
            default:
                break;
        }
    }
}
