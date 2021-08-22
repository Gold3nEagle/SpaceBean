using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
     
    public Transform playerOne, playerTwo;
    CinemachineTargetGroup targetGroup;

    private void Start()
    {
        targetGroup = GetComponent<CinemachineTargetGroup>(); 
    }
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            targetGroup.RemoveMember(playerTwo);

        if (Input.GetMouseButtonDown(1))
            targetGroup.RemoveMember(playerOne);

        if (Input.GetMouseButtonDown(2))
            targetGroup.AddMember(playerOne, 1, 0);

        if (Input.GetMouseButtonDown(3))
            targetGroup.AddMember(playerTwo, 1, 0); 
    }
}
