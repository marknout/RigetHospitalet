
using UnityEngine;
using System.Collections;


public class water : MonoBehaviour
{

    private SpawnObject Flower;
    public UnityEngine.SpriteRenderer CircleWater;
    public UnityEngine.SpriteRenderer CircleAxe;
    public UnityEngine.SpriteRenderer CircleInfo;
    public UnityEngine.SpriteRenderer CirclePoke;
    public UnityEngine.SpriteRenderer CircleShovel;
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
        print("water");
        if (Input.GetMouseButtonDown(0))
        {
            StaticPlayer.playerState = StaticPlayer.PlayerState.waterState;
            CircleWater.enabled = true;
            CircleAxe.enabled = false;
            CircleInfo.enabled = false;
            CirclePoke.enabled = false;
            CircleShovel.enabled = false;
            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();




        }


    }


    

}
