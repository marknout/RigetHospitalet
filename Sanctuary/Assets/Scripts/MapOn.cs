﻿
using UnityEngine;
using System.Collections;


public class MapOn : MonoBehaviour
{
    public Sprite newSprite;
    public AudioSource ClickSound;
    public GameObject Tree5;
    public UnityEngine.SpriteRenderer speechBubble;
    public UnityEngine.SpriteRenderer Ring;
    public CircleCollider2D Cirle;

    void Start()
    {

    }

    void Update()
    {


       





        if (GameObject.FindGameObjectsWithTag("Tree1").Length > 7)
        {
            
            speechBubble.enabled = true;
            Cirle.enabled = true;
            Ring.enabled = true;
            ClickSound.enabled = true;
        }


    }



  





}
