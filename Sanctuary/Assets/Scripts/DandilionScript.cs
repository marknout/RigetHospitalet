using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandilionScript : MonoBehaviour
{

    public ParticleSystem dandilionSeeds;
   
    public void DoTheSeeds()
    {
        if (StaticPlayer.playerState == StaticPlayer.PlayerState.noState)
        {
            dandilionSeeds.Play();
            this.gameObject.GetComponent<Collider>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }

    }
}
