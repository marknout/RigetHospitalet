using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request : MonoBehaviour
{
    public SpriteRenderer speechBubble;
    public AudioSource ClickSound;
    public AudioSource EnterSound;
    public AudioSource ExitSound;
    private DeleteFlower HiddenItem;
    Collider coll;
    private int AmountBees;
    // Use this for initialization
    void Start()
    {
        coll = GetComponent<Collider>();
        speechBubble.enabled = false;
    }

    private void Update()
    {
        if(AmountBees == 5)
        {

            print("works");
            speechBubble.enabled = true;
            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();
        }
    }



 

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bees")
        {
            AmountBees++;

            print("exit");
            if (ExitSound != null)
            {
                EnterSound.pitch = Random.Range(0.8f, 1.2f);
            ExitSound.Play();
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bees")
        {
            AmountBees--;

            print("exit");

           if(ExitSound!= null)
            {
                ExitSound.pitch = Random.Range(0.8f, 1.2f);
                ExitSound.Play();
            }
           
        }
    }




    //  void OnCollisionEnter2D(Collision2D collision)



}





