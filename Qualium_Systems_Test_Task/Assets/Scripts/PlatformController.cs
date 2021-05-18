using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    float rotationSpeed = 0.5f;
    
    // Update is called once per frame
    void Update()
    {
        ProcessRotation();
    }

   
    private void ProcessRotation()
    {
        float xRotation = Input.GetAxis("Vertical") * rotationSpeed;
        transform.Rotate(xRotation, 0, 0);
        float zRotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.Rotate(0, 0, -zRotation);
    }
}
