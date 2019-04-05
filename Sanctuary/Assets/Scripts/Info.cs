using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public SpriteRenderer speechBubble;
    // Use this for initialization
    void Start()
    {
        speechBubble.enabled = false;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if ((StaticPlayer.playerState == StaticPlayer.PlayerState.infoState))
            {
                speechBubble.enabled = true;
            }
         }


    }

    void OnMouseExit()
    {
       
                speechBubble.enabled = false;
            
        


    }




}
