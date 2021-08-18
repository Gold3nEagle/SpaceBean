using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public GameController gameController;
    public GameObject deathFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameController.ChangeLoseText("You evaporated!");
            deathFX.SetActive(true);
        }
    }

}
