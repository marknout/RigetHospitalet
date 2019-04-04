using UnityEngine;
using System.Collections;

public class SpriteOrder : MonoBehaviour {

   
    void Start()
    {
        GetComponent<SpriteRenderer>().sortingOrder = -(int)(transform.position.y);
    }

}
