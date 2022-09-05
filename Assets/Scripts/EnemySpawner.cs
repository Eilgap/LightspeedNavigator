using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class EnemySpawner : MonoBehaviour
{
    public GameObject bomb;
    public GameObject ast;
    public int rand;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - t >= 2.5f)
        {
            t = Time.time;
            rand = Random.Range(0, 14);
            switch(rand)
            {
                case 0:
                    pat0();
                    break;
                case 1:
                    pat1();
                    break;
                case 2:
                    pat2();
                    break;
                case 3:
                    pat3();
                    break;
                case 4:
                    pat4();
                    break;
                case 5:
                    pat5();
                    break;
                case 6:
                    pat6();
                    break;
                case 7:
                    pat7();
                    break;
                case 8:
                    pat8();
                    break;
                case 9:
                    pat9();
                    break;
                case 10:
                    pat10();
                    break;
                case 11:
                    pat11();
                    break;
                case 12:
                    pat12();
                    break;
                case 13:
                    pat13();
                    break;
            }
        }
    }

    void pat0()
    {
        Vector3 e1 = Vector3.zero;
        e1.x = 27;
        Instantiate(ast, e1, Quaternion.identity);
    }

    void pat1()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        e1.y = 8;
        e2.y = -8;
        e1.x = 27;
        e2.x = 27;
        Instantiate(ast, e1, Quaternion.identity);
        Instantiate(ast, e2, Quaternion.identity);
    }

    void pat2()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e1.x = 27;
        e2.x = 27;
        Instantiate(ast, e1, Quaternion.identity);
        Instantiate(ast, e2, Quaternion.identity);
    }

    void pat3()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        e1.y = 0;
        e2.y = -8;
        e1.x = 27;
        e2.x = 27;
        Instantiate(ast, e1, Quaternion.identity);
        Instantiate(ast, e2, Quaternion.identity);
    }

    void pat4()
    {
        Vector3 e1 = Vector3.zero;
        e1.x = 27;
        Instantiate(bomb, e1, Quaternion.identity);
    }

    void pat5()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        e1.y = 8;
        e2.y = -8;
        e1.x = 27;
        e2.x = 27;
        Instantiate(bomb, e1, Quaternion.identity);
        Instantiate(bomb, e2, Quaternion.identity);
    }

    void pat6()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        e1.y = 0;
        e2.y = -8;
        e1.x = 27;
        e2.x = 27;
        Instantiate(bomb, e1, Quaternion.identity);
        Instantiate(bomb, e2, Quaternion.identity);
    }

    void pat7()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e1.x = 27;
        e2.x = 27;
        Instantiate(bomb, e1, Quaternion.identity);
        Instantiate(bomb, e2, Quaternion.identity);
    }

    void pat8()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        Vector3 e3 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e3.y = -8;
        e1.x = 27;
        e2.x = 29;
        e3.x = 27;
        Instantiate(bomb, e1, Quaternion.identity);
        Instantiate(bomb, e2, Quaternion.identity);
        Instantiate(bomb, e3, Quaternion.identity);
    }

    void pat9()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        Vector3 e3 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e3.y = -8;
        e1.x = 27;
        e2.x = 32;
        e3.x = 27;
        Instantiate(bomb, e1, Quaternion.identity);
        Instantiate(bomb, e3, Quaternion.identity);
        Instantiate(bomb, e2, Quaternion.identity);
    }

    void pat10()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        Vector3 e3 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e3.y = -8;
        e1.x = 32;
        e2.x = 26;
        e3.x = 32;
        Instantiate(bomb, e1, Quaternion.identity);
        Instantiate(bomb, e3, Quaternion.identity);
        Instantiate(ast, e2, Quaternion.identity);
    }

    void pat11()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        Vector3 e3 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e3.y = -8;
        e1.x = 26;
        e2.x = 30;
        e3.x = 26;
        Instantiate(ast, e1, Quaternion.identity);
        Instantiate(ast, e3, Quaternion.identity);
        Instantiate(bomb, e2, Quaternion.identity);
    }

    void pat12()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        Vector3 e3 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e3.y = -8;
        e1.x = 34;
        e2.x = 25;
        e3.x = 34;
        Instantiate(ast, e1, Quaternion.identity);
        Instantiate(ast, e3, Quaternion.identity);
        Instantiate(ast, e2, Quaternion.identity);
    }

    void pat13()
    {
        Vector3 e1 = Vector3.zero;
        Vector3 e2 = Vector3.zero;
        Vector3 e3 = Vector3.zero;
        e1.y = 8;
        e2.y = 0;
        e3.y = -8;
        e1.x = 25;
        e2.x = 34;
        e3.x = 25;
        Instantiate(ast, e1, Quaternion.identity);
        Instantiate(ast, e3, Quaternion.identity);
        Instantiate(ast, e2, Quaternion.identity);
    }
}
