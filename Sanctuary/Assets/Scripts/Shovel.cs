
using UnityEngine;
using System.Collections;

public class Shovel : MonoBehaviour
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

            StaticPlayer.playerState = StaticPlayer.PlayerState.shovelState;
            CircleWater.enabled = false;
            CircleAxe.enabled = false;
            CircleInfo.enabled = false;
            CirclePoke.enabled = false;
            CircleShovel.enabled = true;
            ClickSound.pitch = Random.Range(0.8f,1.2f);
            ClickSound.Play();



        }


    }




}