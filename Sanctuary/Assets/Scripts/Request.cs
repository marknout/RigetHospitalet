using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request : MonoBehaviour
{
    public SpriteRenderer speechBubble;
    public AudioSource ClickSound;
    private DeleteFlower HiddenItem;
    Collider coll;
    // Use this for initialization
    void Start()
    {
        coll = GetComponent<Collider>();
        speechBubble.enabled = false;
    }





    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.isTrigger && coll.CompareTag("Tree1"))
        {
            speechBubble.enabled = true;
            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tree1")
        {
            
            Destroy(gameObject);
        }
    }





  //  void OnCollisionEnter2D(Collision2D collision)



}





