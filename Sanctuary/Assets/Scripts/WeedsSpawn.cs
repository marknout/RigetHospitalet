using UnityEngine;
using System.Collections;

public class WeedsSpawn : MonoBehaviour
{

    private bool Spawn1 = true;
    public GameObject Food;
    private float STimer;
    public Vector2 center;
    public Vector2 size;

    void Start()
    {
        STimer = Random.Range(10f, 60f);
    }

    void Update()
    {
        if (Spawn1 == true)
        {
            Vector2 pos = center + new Vector2(Random.Range(-size.x / 3, size.x / 3), Random.Range(-size.y / 7, size.y / 7));

            Instantiate(Food, pos, Quaternion.identity);
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        Spawn1 = false;
        yield return new WaitForSeconds(STimer);
        Spawn1 = true;
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);


    }
}
