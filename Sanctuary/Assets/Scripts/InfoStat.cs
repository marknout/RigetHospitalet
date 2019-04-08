
using UnityEngine;
using System.Collections;


public class InfoStat : MonoBehaviour
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
            StaticPlayer.playerState = StaticPlayer.PlayerState.infoState;
            CircleWater.enabled = false;
            CircleAxe.enabled = false;
            CircleInfo.enabled = true;
            CirclePoke.enabled = false;
            CircleShovel.enabled = false;
            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();






        }


    }




}