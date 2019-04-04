
using UnityEngine;
using System.Collections;
using System;

public class PlantFlowers: MonoBehaviour
{
    private SpawnObject Flower;


    void Start()
    {
        Flower = GetComponent<SpawnObject>();
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (StaticPlayer.playerState == StaticPlayer.PlayerState.waterState)
            {
                StartCoroutine(Example());
            Flower.enabled = true;
        }
        }


    }



    IEnumerator Example()
    {
       
        yield return 3;
        
    }

 
}





     
       