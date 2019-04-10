
using UnityEngine;
using System.Collections;


public class MapOn : MonoBehaviour
{
    public Sprite newSprite;
    public AudioSource ClickSound;
    public GameObject Tree5;
    public SpriteRenderer speechBubble;
    public SpriteRenderer Ring;
    public CircleCollider2D Cirle;

    void Start()
    {

    }

    void Update()
    {


       





        if (GameObject.FindGameObjectsWithTag("Tree1").Length > 6)
        {
            
            speechBubble.enabled = true;
            Cirle.enabled = true;
            Ring.enabled = true;
            ClickSound.enabled = true;
        }


    }



  





}
