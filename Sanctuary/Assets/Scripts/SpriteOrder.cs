using UnityEngine;
using System.Collections;

public class SpriteOrder : MonoBehaviour {

    void Update()
    {
        GetComponent<SpriteRenderer>().sortingOrder = -(int)(transform.position.y);
    }


   

}
