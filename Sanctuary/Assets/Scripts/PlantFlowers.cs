
using UnityEngine;
using System.Collections;

public class PlantFlowers: MonoBehaviour
{

    private bool hasSpawned = false;
    private FlowerSpawner Flower;
    private DeleteFlower DeleteFlower;
    public AudioSource ClickSound;


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
                DeleteFlower.enabled = true;
                ClickSound.pitch = Random.Range(0.8f, 1.2f);
                ClickSound.Play();

            }
        }
    }
}





     
       