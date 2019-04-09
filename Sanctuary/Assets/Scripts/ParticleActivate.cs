using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivate : MonoBehaviour
{

    public ParticleSystem particles;
    public float delay = 1f;

    Collider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (StaticPlayer.playerState == StaticPlayer.PlayerState.noState)
        {
            particles.Play();
            StartCoroutine(ParticleCooldown());
        }
    }

    IEnumerator ParticleCooldown()
    {
        col.enabled = false;
        yield return new WaitForSeconds(delay);
        col.enabled = true;
    }
}
