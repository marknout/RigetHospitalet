using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivate : MonoBehaviour
{

    public ParticleSystem particles;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (StaticPlayer.playerState == StaticPlayer.PlayerState.noState)
            particles.Play();
            this.gameObject.GetComponent<Collider>().enabled = false;



    }
}
