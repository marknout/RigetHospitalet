using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandilionScript : MonoBehaviour
{

    public ParticleSystem dandilionSeeds;
    

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
        dandilionSeeds.Play();
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
