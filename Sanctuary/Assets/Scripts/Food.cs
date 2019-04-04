using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	public GameObject FoodPrefab;
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Instantiate(FoodPrefab, this.transform.position, Quaternion.identity);
		}
	}
}
