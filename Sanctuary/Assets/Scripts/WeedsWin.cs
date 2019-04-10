using UnityEngine;
using System.Collections;


public class WeedsWin : MonoBehaviour
{
  
    public AudioSource ClickSound;
    
    public SpriteRenderer Sprite;
    
    public BoxCollider2D Cirle;

    void Start()
    {

    }

    void Update()
    {








        if (GameObject.FindGameObjectsWithTag("Weeds").Length < 1)
        {

            Sprite.enabled = true;
            Cirle.enabled = true;
           
            ClickSound.enabled = true;
            
        }


    }









}
