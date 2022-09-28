using UnityEngine;
using System.Collections;

public class TouchTes : MonoBehaviour
{
    public bool isActive = false;
    Color activeColor = new Color();
    void Update()
    {
        if (isActive)
        {
            activeColor = Color.red;
            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);
                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, -screenTouch.deltaPosition.x, 0f);
                }
                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = false;
                }
            }
        }
        else
        {
            activeColor = Color.white;
        }

        GetComponent<MeshRenderer>().material.color = activeColor;
    }
}