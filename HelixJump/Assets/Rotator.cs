using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent <Rigidbody> ();
    }
    void OnMouseDrag(){
        dragging = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
            dragging = false;
        }
    }
    void FixedUpdate(){
        if(dragging){
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down* x);
            Touch touch = Input.GetTouch(0);

            Debug.Log(touch.phase);
            // rb.AddTorque(Vector3.right* y);
        }
    }
}
