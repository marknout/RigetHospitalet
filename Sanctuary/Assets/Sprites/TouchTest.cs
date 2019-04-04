using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    public GameObject Foodprefab;
    public Vector2 center;
    public Vector2 size;

  

    // Update is called once per frame
    void Update()
    {

    
    
     if      (Input.GetMouseButtonDown(0))   
            {
            Touch touch = Input.GetTouch(0);

           // Vector2 pos = center + new Vector2(Random.Range(-size.x / 3, size.x / 3), Random.Range(-size.y / 7, size.y / 7));

            //Instantiate(Foodprefab, pos, Quaternion.identity);


            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
              transform.position = touchPosition;



        }

      
}
}
