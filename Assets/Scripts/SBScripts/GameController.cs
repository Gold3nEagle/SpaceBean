using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
     
    public Animator winPanelAnimator, losePanelAnimator;
    public LevelLoader levelLoader;
    public ScoreManager scoreManager;
    public Text loseText;
    public GameObject playerObj;
    public float panelWaitTime = 1f;

    AudioSource audioSource;
    public AudioClip[] clips;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void WinGame()
    {
        scoreManager.CalculateScore();
        StopPlayer();
        StartCoroutine(WinOrLose(1));
        audioSource.clip = clips[0];
        audioSource.Play();

    }

    public void LoseGame()
    {
        StartCoroutine(WinOrLose(2));
        audioSource.clip = clips[1];
        
    }

    public void ChangeLoseText(string loseString)
    {
        loseText.text = loseString;
        StopPlayer();
        LoseGame(); 
    }

    void StopPlayer()
    {
        playerObj.GetComponent<Push>().enabled = false;
        playerObj.GetComponent<Rotate>().enabled = false;
        playerObj.GetComponent<SpriteRenderer>().enabled = false;
        playerObj.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        playerObj.GetComponent<BoxCollider2D>().enabled = false;
    }
     
    IEnumerator WinOrLose(int state)
    { 
        yield return new WaitForSeconds(panelWaitTime);

        if(state == 1)
        {
            winPanelAnimator.SetBool("isShowing", true);
        }

        if(state == 2)
        { 
            losePanelAnimator.SetBool("isShowing", true);
            audioSource.Play();
        } 
    }
      
}
