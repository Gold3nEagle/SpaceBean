using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuffFX : MonoBehaviour
{

    public GameObject puff;
    bool hasPlayed = false;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            if(hasPlayed == false)
            {
                if (hasPlayed == false)
                {
                    Instantiate(puff, transform.position, Quaternion.identity);
                    audioSource.Play();
                    hasPlayed = true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            hasPlayed = false;
        }
    }
     
}
