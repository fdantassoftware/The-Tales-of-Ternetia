using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateExploreScene : MonoBehaviour
{
    private int degrees = 10;
    void Update()
    {
        if (Input.GetMouseButton(1)) {
            degrees = 10;
            transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * degrees);
        } else {
            degrees = 0;
        }
        
    }
}
