using UnityEngine;
using System.Collections;

public class FlowerSpawner : MonoBehaviour
{
    [HideInInspector]
    public bool Spawn1 = false;
    
    public GameObject Food;

    public float STimerMin, STimerMax;
    public Vector2 center;
    public Vector2 size;
    public AudioSource ClickSound;

    void Start()
    {
        //STimer = Random.Range(10f, 60f);
    }

    void Update()
    {

        if (Spawn1 == true)
        {
            Spawn1 = false;
            Vector2 pos = center + new Vector2(Random.Range(-size.x / 3, size.x / 3), Random.Range(-size.y / 7, size.y / 7));
            Instantiate(Food, pos, Quaternion.identity);
            ClickSound.pitch = Random.Range(0.8f, 1.2f);
            ClickSound.Play();
        }
    }

    public IEnumerator Timer(float time)
    {
        yield return new WaitForSeconds(time);
        Spawn1 = true;
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);


    }
}

