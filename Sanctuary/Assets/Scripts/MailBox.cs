using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailBox : MonoBehaviour
{
    public UnityEngine.SpriteRenderer speechBubble;
    public AudioSource ClickSound;
    // Use this for initialization
    void Start()
    {
        speechBubble.enabled = false;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
                speechBubble.enabled = true;
                ClickSound.pitch = Random.Range(0.8f, 1.2f);
                ClickSound.Play();
            
        }


    }

    void OnMouseExit()
    {

        speechBubble.enabled = false;




    }




}
