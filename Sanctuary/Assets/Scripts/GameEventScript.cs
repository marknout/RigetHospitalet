using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventScript : MonoBehaviour
{
    public Camera cam;
    public LayerMask mask;
    public GameObject ripple;
    public float time;
    public AudioSource aSource;
    public AudioClip splash;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource> (); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit, Mathf.Infinity, mask, QueryTriggerInteraction.Ignore))
            {
                GameObject newRipple;
                newRipple = Instantiate(ripple, hit.point, transform.rotation);
                aSource.PlayOneShot(splash);
                Destroy(newRipple, time);
            }
        }
    }
}
