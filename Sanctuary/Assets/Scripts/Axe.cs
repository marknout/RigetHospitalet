
using UnityEngine;
using System.Collections;


public class Axe : MonoBehaviour
{

    private SpawnObject Flower;
    public SpriteRenderer CircleWater;
    public SpriteRenderer CircleAxe;
    public SpriteRenderer CircleInfo;
    public SpriteRenderer CirclePoke;
    public SpriteRenderer CircleShovel;
    public AudioSource ClickSound;


    void Start()
    {
        CircleWater.enabled = false;
        CircleAxe.enabled = false;
        CircleInfo.enabled = false;
        CirclePoke.enabled = false;
        CircleShovel.enabled = false;
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StaticPlayer.playerState = StaticPlayer.PlayerState.axeState;
            CircleWater.enabled = false;
            CircleAxe.enabled = true;
            CircleInfo.enabled = false;
            CirclePoke.enabled = false;
            CircleShovel.enabled = false;
            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();




        }


    }




}






