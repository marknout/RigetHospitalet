using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSprite : MonoBehaviour
{
    public bool visualOn;
    public AudioSource aSource;
    public AudioClip soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        visualOn = false;
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (visualOn)
        //{
        //    GetComponent<SpriteRenderer>().enabled = false;
        //
        //}
        //if (!visualOn)
        //{
        //    GetComponent<SpriteRenderer>().enabled = true;
        //
        //}

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.enabled = !visualOn;
    }

<<<<<<< HEAD
    void OnMouseDown()
    {
        if (StaticPlayer.playerState == StaticPlayer.PlayerState.noState)
        {
            visualOn = !visualOn;
            aSource.PlayOneShot(soundEffect);
        }
=======
    public void DoTheSwitch()
    {
        visualOn = !visualOn;
        aSource.PlayOneShot(soundEffect);
>>>>>>> parent of 273bc44... mathias
    }
                   
}
