using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class MainMenu : MonoBehaviour
{

    LevelLoader levelLoader; 
    public GameObject panelObject; 

    private void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();

        GameObject otherMusic = GameObject.FindGameObjectWithTag("Bullet");
        Destroy(otherMusic);
    }

    public void PlayGame()
    {
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
