
using UnityEngine;
using System.Collections;
using System;

public class Grow : MonoBehaviour
{
    public Sprite newSprite;


    void Start()
    {
    
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (StaticPlayer.playerState == StaticPlayer.PlayerState.waterState)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
            }
        }


    }



    IEnumerator Example()
    {

        yield return 3;

    }


}
