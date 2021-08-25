using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class MainMenu : MonoBehaviour
{

    LevelLoader levelLoader;  

    private void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();

        GameObject otherMusic = GameObject.FindGameObjectWithTag("Bullet");
        Destroy(otherMusic);
    }

    public void PlayGame(int players)
    {
        PlayerPrefs.SetInt("GamePlayers", players);
        levelLoader.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
  
    public void GoToWebsite()
    {
        Application.OpenURL("https://geagle.tech");
    }

    public void GoToIG()
    {
        Application.OpenURL("https://instagram.com/geagle.tech");
    }
  
}
