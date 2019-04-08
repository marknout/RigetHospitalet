
using UnityEngine;
using System.Collections;


public class RemoveFlowers: MonoBehaviour
{
    private SpawnObject RemoveFlower;
    public AudioSource ClickSound;

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
                ClickSound.pitch = Random.Range(0.8f, 1.2f);
                ClickSound.Play();
                Destroy(gameObject);
                ClickSound.pitch = Random.Range(0.8f, 1.2f);
                ClickSound.Play();
            }
           
            
        }

      
    }



  
 
}





     
       