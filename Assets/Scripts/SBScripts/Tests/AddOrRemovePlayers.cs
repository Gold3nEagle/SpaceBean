using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOrRemovePlayers : MonoBehaviour
{

    CameraController cameraController;
    GameController gameController;
    private void Start()
    {
        int players = PlayerPrefs.GetInt("GamePlayers");
        cameraController = FindObjectOfType<CameraController>();
        gameController = FindObjectOfType<GameController>();

        if (players == 1)
        { 
            gameController.KillPlayer(2);
        }
    }


}
