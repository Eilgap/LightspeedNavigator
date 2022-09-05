using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text sc;
    public Scoring s;
    public float t = 0;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        s = FindObjectOfType<Scoring>();
        t = Time.time;
        score = s.GiveScore();
    }

    // Update is called once per frame
    void Update()
    {
        sc.text = "Final Score: " + score.ToString();
        if(Time.time - t >= 5)
        {
            Application.LoadLevel("MainMenu"); 
        }
    }
}
