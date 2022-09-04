using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public float score;
    public int scoreIncTime;
    public Text scoreUI;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreIncTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreIncTime++;
        if(scoreIncTime >= 500)
        {
            score = score + 10;
            scoreIncTime = 0;
        }
        scoreUI.text = "Score: " + score.ToString();
    }

    public void Death()
    {
        lives--;
    }
}
