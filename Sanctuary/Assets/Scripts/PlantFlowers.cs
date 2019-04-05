
using UnityEngine;
using System.Collections;
using System;

public class PlantFlowers: MonoBehaviour
{
    private SpawnObject Flower;
    private DeleteFlower DeleteFlower;


    void Start()
    {
        Flower = GetComponent<SpawnObject>();
        DeleteFlower = GetComponent<DeleteFlower>();
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (StaticPlayer.playerState == StaticPlayer.PlayerState.waterState)
            {
                StartCoroutine(Example());
            Flower.enabled = true;
                DeleteFlower.enabled = true;
            }
        }


    }



    IEnumerator Example()
    {
       
        yield return 3;
        
    }

 
}





     
       