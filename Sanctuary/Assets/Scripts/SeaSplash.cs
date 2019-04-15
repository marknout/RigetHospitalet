using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaSplash : MonoBehaviour
{
    public GameObject ripple;
    public float time;
    public AudioSource aSource;
    public AudioClip splash;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    public void DoTheRipple(Vector3 point)
    {
        GameObject newRipple;
        newRipple = Instantiate(ripple, point, transform.rotation);
        aSource.PlayOneShot(splash);
        Destroy(newRipple, time);
    }

}
