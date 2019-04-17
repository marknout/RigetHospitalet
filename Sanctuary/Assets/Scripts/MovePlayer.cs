using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform target;
    public float speed;
 
    public GameObject Icons;
    public GameObject Text;



    void Start()
    {

        Icons.SetActive(false);
        Text.SetActive(false);
    }


    private void OnMouseDrag()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }




    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tree1")
        {
            Icons.SetActive(true);
            Text.SetActive(true);

            

        }
        }
    


    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tree1")
        {
            Icons.SetActive(false);
            Text.SetActive(false);

            print("exit");

           


        }
    }






}


