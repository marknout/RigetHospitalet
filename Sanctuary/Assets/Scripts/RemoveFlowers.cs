
using UnityEngine;
using System.Collections;
using System;

public class RemoveFlowers: MonoBehaviour
{
    private SpawnObject RemoveFlower;


    void Start()
    {
        RemoveFlower = GetComponent<SpawnObject>();
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(StaticPlayer.playerState == StaticPlayer.PlayerState.axeState)
            {
                Destroy(gameObject);
            }
            if (StaticPlayer.playerState == StaticPlayer.PlayerState.waterState)
            {
              
                


            }
            
        }

      
    }



  
 
}





     
       