using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public GameObject Icons;
    public GameObject Text;
    public AudioSource ClickSound;
    // Use this for initialization
    void Start()
    {
        Icons.SetActive(false);
        Text.SetActive(false);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Icons.SetActive(true);

            Text.SetActive(true);

            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();

        }


    }

    void OnMouseExit()
    {

        Icons.SetActive(false);

        Text.SetActive(false);


    }




}
