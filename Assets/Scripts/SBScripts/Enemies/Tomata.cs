using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomata : MonoBehaviour
{
    public GameController gameController;
    public AudioSource explosionAudioSource;
    public GameObject deathFX;

 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            explosionAudioSource.Play();
            Instantiate(deathFX, collision.gameObject.transform.position, Quaternion.identity);
            gameController.KillPlayer(1);
        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            explosionAudioSource.Play();
            Instantiate(deathFX, collision.gameObject.transform.position, Quaternion.identity);
            gameController.KillPlayer(2);
        }


    }

}
