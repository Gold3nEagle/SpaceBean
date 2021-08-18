using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{

    AudioSource audioSource;
   public AudioClip[] audioClips;
    int currentScene;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Bullet");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!audioSource.isPlaying && currentScene != 0)
        {
            audioSource.clip = audioClips[(int)Random.Range(0, 3)];
            audioSource.Play();
        }
    }
 
}
