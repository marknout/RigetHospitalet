using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

	public GameObject Foodprefab;



	public Vector2 center;
	public Vector2 size;

	// Use this for initialization
	void Start () {

	SpawnFood();


    }
	
	// Update is called once per frame
	void Update () {
		
	}

   


public void SpawnFood(){

		Vector2 pos = center + new Vector2(Random.Range(-size.x / 3, size.x / 3), Random.Range(-size.y / 7, size.y / 7));

		Instantiate(Foodprefab, pos, Quaternion.identity);
	}




    void OnDrawGizmosSelected(){

	Gizmos.color = new Color(1,0,0,0.5f);
	Gizmos.DrawCube(center, size);


}
}
