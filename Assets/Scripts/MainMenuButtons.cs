using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
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
