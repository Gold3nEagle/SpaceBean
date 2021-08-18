using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : MonoBehaviour
{

    public GameController gameController; 

    // Start is called before th 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Push>().enabled = false;
            collision.gameObject.GetComponent<Rotate>().enabled = false; 
            gameController.WinGame();
            gameObject.SetActive(false);
        }
    }
}
