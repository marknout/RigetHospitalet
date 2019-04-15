using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeEnabler : MonoBehaviour
{
    public ParticleSystem smoke;
    public bool smoking, alive;
    public float rate = 1f;
    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        smoking = true;
    }

    // Update is called once per frame
    void Update()
    {
        var main = smoke.main;
        speed = Mathf.Lerp(speed, 0.5f, rate * Time.deltaTime);
        main.simulationSpeed = speed;
        if (smoking)
        {
            if (!smoke.IsAlive())
            {
                speed = 3;
                smoke.Play();
            }
                
        }
        else
        {
            if (smoke.IsAlive())
            {
                smoke.Stop();
                speed = 0.5f;
                StartCoroutine(ParticleClear());                
            }
        }

        alive = smoke.IsAlive();
    }

    private void OnMouseDown()
    {
        smoking = !smoking;
    }

    IEnumerator ParticleClear()
    {
        yield return new WaitForSeconds(6f);
        smoke.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
}
