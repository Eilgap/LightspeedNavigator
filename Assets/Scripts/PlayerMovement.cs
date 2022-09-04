using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{   
    public float speed;

    void Start()
    {

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
    }
}
