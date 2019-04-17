using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimation : MonoBehaviour { 
      public float delay = 1f;
      private Animator anim;
      public AudioSource aSource;
      public AudioClip soundEffect;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        StartCoroutine(ResetAnim());
        aSource.PlayOneShot(soundEffect);

    }

    IEnumerator ResetAnim()
    {
        anim.SetBool("isClicked", true);
        yield return new WaitForSeconds(delay);
        anim.SetBool("isClicked", false);
    }
 }
