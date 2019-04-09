
using UnityEngine;
using System.Collections;


public class Grow : MonoBehaviour
{
    public Sprite newSprite;
    public AudioSource ClickSound;


    void Start()
    {
    
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (StaticPlayer.playerState == StaticPlayer.PlayerState.waterState)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                ClickSound.pitch = Random.Range(0.8f, 1.2f);
                ClickSound.Play();
            }
        }


    }



    IEnumerator Example()
    {

        yield return 3;

    }


}
