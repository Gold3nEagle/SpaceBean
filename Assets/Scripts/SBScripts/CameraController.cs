using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public enum GroupState
{
    RemoveMember,
    AddMember
}

public class CameraController : MonoBehaviour
{
     
    public Transform playerOne, playerTwo;
    CinemachineTargetGroup targetGroup;
    GroupState state;

    private void Awake()
    {
        targetGroup = GetComponent<CinemachineTargetGroup>(); 
    }

    public void RemoveOrAdd(GroupState state, int player)
    {

        if (state == GroupState.RemoveMember)
        {
            if (player == 1)
                targetGroup.RemoveMember(playerOne);
            else
                targetGroup.RemoveMember(playerTwo);
        }

        if (state == GroupState.AddMember)
            if(player == 1)
                targetGroup.AddMember(playerOne, 1, 0);
            else
                targetGroup.AddMember(playerTwo, 1, 0);
    }

     
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //    RemoveOrAdd(GroupState.RemoveMember, 2);

        //if (Input.GetMouseButtonDown(1))
        //    RemoveOrAdd(GroupState.RemoveMember, 1);

    }
}
