using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
   public float rotatespeed = 10f;
 private float _startingPosition;
   
 void Update()
 {
     if (Input.touchCount > 0)
     {
         Touch touch = Input.GetTouch(0);
         switch (touch.phase)
         {
             case TouchPhase.Began:
                 _startingPosition = touch.position.y;
                 break;
             case TouchPhase.Moved:
                 if (_startingPosition > touch.position.y)
                 {
                     transform.Rotate(Vector3.up, -rotatespeed * Time.deltaTime);
                 }
                 else if (_startingPosition < touch.position.y)
                 {
                     transform.Rotate(Vector3.up, rotatespeed * Time.deltaTime);
                 }
                 break;
             case TouchPhase.Ended:
                 Debug.Log("Touch Phase Ended.");
                 break;
             }
         }
     }
 
}
