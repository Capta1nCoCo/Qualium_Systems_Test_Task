using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] Joystick joystick;

    [SerializeField] [Range(0.1f, 1f)] float rotationSpeed = 0.5f;
    
    // Update is called once per frame
    void Update()
    {
        ProcessRotation();
    }

   
    private void ProcessRotation()
    {
        float xRotation = joystick.Vertical * rotationSpeed;
        transform.Rotate(xRotation, 0, 0);
        float zRotation = joystick.Horizontal * rotationSpeed;
        transform.Rotate(0, 0, -zRotation);
    }
}
