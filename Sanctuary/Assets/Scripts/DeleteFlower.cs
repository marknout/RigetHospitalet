using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFlower : MonoBehaviour
{
    public GameObject FlowerToRemove;



    // Start is called before the first frame update
    void Start()
    {

        Destroy(FlowerToRemove.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
