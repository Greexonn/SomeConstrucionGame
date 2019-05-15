using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (true)
        {
            Vector3 _rotator = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
            transform.Rotate(_rotator, Space.Self);
        }
    }
}
