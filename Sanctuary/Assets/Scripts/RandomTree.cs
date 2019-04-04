using UnityEngine;
using System.Collections;

public class RandomTree : MonoBehaviour {
	public Sprite[] Trees;
	private int ThisTree;

	// Use this for initialization
	void Start () {
		ThisTree = Random.Range (0, Trees.Length);

		GetComponent<SpriteRenderer> ().sprite = Trees [ThisTree];
	}
}
