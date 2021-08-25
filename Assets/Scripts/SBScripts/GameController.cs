using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 

public class GameController : MonoBehaviour
{
     
    public TweenAnimsManager winPanel, losePanel;

    public LevelLoader levelLoader;
    public ScoreManager scoreManager;
    public CameraController cameraController;

    public Text loseText;
    public GameObject playerOne, flameOne, playerTwo, flameTwo;
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
        StopPlayer(playerOne, flameOne);
        StopPlayer(playerTwo, flameTwo);
        StartCoroutine(WinOrLose(1));
        audioSource.clip = clips[0];
        audioSource.Play(); 
    }

    public void LoseGame()
    {

        StopPlayer(playerOne, flameOne);
        StopPlayer(playerTwo, flameTwo);
        StartCoroutine(WinOrLose(2));
        audioSource.clip = clips[1]; 
    }
     
    public void KillPlayer(int playerNum)
    {
        cameraController.RemoveOrAdd(GroupState.RemoveMember, playerNum);
        if(playerNum == 1) StopPlayer(playerOne, flameOne);
        if (playerNum == 2) StopPlayer(playerTwo, flameTwo);

        if (!flameOne.activeInHierarchy && !flameTwo.activeInHierarchy) LoseGame(); 
    }
 
    void StopPlayer(GameObject playerObj, GameObject flameObj)
    {
        playerObj.GetComponent<Push>().enabled = false;
        playerObj.GetComponent<Rotate>().enabled = false;
        playerObj.GetComponent<SpriteRenderer>().enabled = false;
        playerObj.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        playerObj.GetComponent<Rigidbody2D>().gravityScale = 0f;
        playerObj.GetComponent<BoxCollider2D>().enabled = false; 
        flameObj.SetActive(false); 
    }
     
    IEnumerator WinOrLose(int state)
    { 
        yield return new WaitForSeconds(panelWaitTime);

        if(state == 1)
        {
            winPanel.PanelIn();
        }

        if(state == 2)
        {
            losePanel.PanelIn();
            audioSource.Play();
        } 
    }
      
}
