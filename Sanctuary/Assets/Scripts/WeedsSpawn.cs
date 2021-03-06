﻿using UnityEngine;
using System.Collections;

public class WeedsSpawn : MonoBehaviour
{

    private bool Spawn2 = true;
    public GameObject Food;
    private float STimer;
    public Vector2 center;
    public Vector2 size;
    public AudioSource ClickSound;
    

    void Start()
    {
        STimer = Random.Range(3f, 15f);
    }

    void Update()
    {
        if (Spawn2 == true)
        {
            Vector2 pos = center + new Vector2(Random.Range(-size.x / 3, size.x / 3), Random.Range(-size.y / 7, size.y / 7));

            Instantiate(Food, pos, Quaternion.identity);
            StartCoroutine(Timer());
            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();
            
        }
    }

    IEnumerator Timer()
    {
        Spawn2 = false;
        yield return new WaitForSeconds(STimer);
        Spawn2 = true;
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);


    }
}
