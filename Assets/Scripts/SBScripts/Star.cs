using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    public GameObject StarFX;
    ScoreManager scoreManager;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        audioSource = GetComponentInParent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            scoreManager.IncreaseScore();
            Instantiate(StarFX, gameObject.transform.position, Quaternion.identity);
            audioSource.Play();
            Destroy(gameObject, 1);
            
        }
    }

}
