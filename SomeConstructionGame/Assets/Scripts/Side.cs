using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : MonoBehaviour
{
    public bool isLocked;

    public Rigidbody body;

    void Start()
    {
        body = GetComponentInParent<Rigidbody>();
    }

    public void AttachObject()
    {
        isLocked = true;
    }
}
