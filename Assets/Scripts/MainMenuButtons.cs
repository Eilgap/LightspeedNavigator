using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public Scoring s;
    // Start is called before the first frame update
    void Start()
    {
        s = FindObjectOfType<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        s.ResetScore();
        s.ResetLives();
        SceneManager.LoadScene("MainGame");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LeaderboardButton()
    {
        SceneManager.LoadScene("Leaderboard");
    }
}
