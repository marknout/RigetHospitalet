
using UnityEngine;
using System.Collections;
using System;

public class Shovel : MonoBehaviour
{

    private SpawnObject Flower;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StaticPlayer.playerState = StaticPlayer.PlayerState.shovelState;
        }


    }





}
