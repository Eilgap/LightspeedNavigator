using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public static float score = 0;
    public float t;
    public Text scoreUI;
    public static int baseLives = 3;
    public static int lives = baseLives;
    private float highFive;
    public AudioSource boom;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    // Start is called before the first frame update
    void Start()
    {
        highFive = PlayerPrefs.GetFloat("hs5", 0);
        t = Time.time;
        boom = GetComponent<AudioSource>();
        switch(lives)
        {
            case 3:
                break;
            case 2:
                Destroy(life1);
                break;
            case 1:
                Destroy(life1);
                Destroy(life2);
                break;
            case 0:
                Destroy(life1);
                Destroy(life2);
                Destroy(life3);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - t >= 2)
        {
            score = score + 10;
            t = Time.time;
        }
        scoreUI.text = "Score: " + score.ToString();
    }

    public void Death()
    {
        lives = lives - 1;
        switch(lives)
        {
            case 3:
                break;
            case 2:
                Destroy(life1);
                break;
            case 1:
                Destroy(life2);
                break;
            case 0:
                Destroy(life1);
                break;
        }
        if(lives <= 0)
        {
            if(/*score > highFive*/false)
            {
                SceneManager.LoadScene("ScoreboardIn");
            }
            else
            {
                SceneManager.LoadScene("ShowScore");
            }
        }
        else
        {
            Application.LoadLevel("MainGame");   
        }
    }

    public void RaiseScore(int temp)
    {
        boom.Play();
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

    public int CurrentLives()
    {
        return lives;
    }

    public float GiveScore()
    {
        return score;
    }
}
