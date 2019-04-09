
using UnityEngine;
using System.Collections;

public class PlantFlowers: MonoBehaviour
{

    private bool hasSpawned = false;
    private FlowerSpawner Flower;
    private DeleteFlower DeleteFlower;
    


    void Start()
    {
        Flower = GetComponent<FlowerSpawner>();
        DeleteFlower = GetComponent<DeleteFlower>();
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (StaticPlayer.playerState == StaticPlayer.PlayerState.waterState && !hasSpawned)
            {
                hasSpawned = true;
                StartCoroutine(Flower.Timer(Random.Range(Flower.STimerMin,Flower.STimerMax)));
                Flower.enabled = true;
                

            }
        }
    }
}





     
       