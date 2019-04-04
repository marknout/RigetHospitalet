
using UnityEngine;
using System.Collections;
using System;

public class water : MonoBehaviour
{

    private SpawnObject Flower;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StaticPlayer.playerState = StaticPlayer.PlayerState.waterState;
        }


    }





}
