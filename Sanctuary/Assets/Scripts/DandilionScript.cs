using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandilionScript : MonoBehaviour
{

    public ParticleSystem particles;
    public float delay = 1f;

    Collider col;

    void Start()
    {
        col = GetComponent<Collider>();
    }

    private void OnMouseDown()
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
