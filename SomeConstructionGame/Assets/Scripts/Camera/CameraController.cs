using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (!SimpleInputHandler.isPlayMode)
        {
            //position
            Vector3 _dir = (transform.forward * Input.GetAxisRaw("Vertical")) + (transform.right * Input.GetAxisRaw("Horizontal"));
            transform.Translate(_dir * Time.deltaTime * 10, Space.World);

            //rotation
            if (Input.GetKey(KeyCode.Mouse1))
            {
                Vector3 _axis = (Vector3.up * Input.GetAxis("Mouse X")) + (transform.right * -Input.GetAxis("Mouse Y"));
                transform.Rotate(_axis, Space.World);
            }
        }
    }
}
