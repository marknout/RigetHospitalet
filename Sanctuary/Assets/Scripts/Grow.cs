
using UnityEngine;
using System.Collections;


public class Grow : MonoBehaviour
{
    public Sprite newSprite;
    public AudioSource ClickSound;
    public ParticleSystem particles;
    public float delay = 1f;
    Collider col;


    void Start()
    {
        col = GetComponent<Collider>();
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (StaticPlayer.playerState == StaticPlayer.PlayerState.waterState)
            {
                this.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = newSprite;
                ClickSound.pitch = Random.Range(0.8f, 1.2f);
                ClickSound.Play();
                particles.Play();
                StartCoroutine(ParticleCooldown());

            }
        }


    }



    IEnumerator ParticleCooldown()
    {
        
        yield return new WaitForSeconds(delay);
        col.enabled = true;
    }


}
