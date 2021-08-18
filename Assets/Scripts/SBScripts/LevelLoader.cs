using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public float waitTime = 1.2f;
    Animator myAnimator;
    MusicController musicController;


    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        musicController = FindObjectOfType<MusicController>();
    }

    public void LoadLevel(int levelIndex)
    {
        StartCoroutine(StartLevel(levelIndex));  
    } 

    public void RetryGame()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator StartLevel(int levelIndex)
    {
        myAnimator.SetTrigger("Fade");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(levelIndex);

    } 
}
