using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public static float score = 0;
    public int scoreIncTime;
    public Text scoreUI;
    public static int baseLives = 3;
    public static int lives = baseLives;
    private float highFive;
    // Start is called before the first frame update
    void Start()
    {
        highFive = PlayerPrefs.GetFloat("hs5", 0);
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
        lives = lives - 1;
        if(lives <= 0)
        {
            if(/*score > highFive*/false)
            {
                SceneManager.LoadScene("ScoreboardIn");
            }
            else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        else
        {
            SceneManager.LoadScene("MainGame");
        }
    }

    public void RaiseScore(int temp)
    {
        score = score + temp;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void ResetLives()
    {
        lives = baseLives;
    }
}
