using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jebakan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // void OnCollisionStay(Collision collision)
    // {
    //     //Check to see if the Collider's name is "Chest"
    //     if (collision.collider.tag == "Jebakan")
    //     {
    //         //Output the message
    //         Debug.Log("Anda Menabrak Jebakan ");
    //         // Destroy(this.gameObject);

    //     }
    // }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Jebakan")
        {
            //Output the message
            Debug.Log("Anda Menabrak Jebakan ");
            Destroy(other.collider.gameObject);

        }
    }
}
