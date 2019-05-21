using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitPreview : MonoBehaviour
{
    public Vector3 axis;
    public float angle;

    private float _currentAngle = 0;

    void Start()
    {
        SimpleInputHandler.OnRotate += ChangeAngle;
    }

    void Destroy()
    {
        SimpleInputHandler.OnRotate -= ChangeAngle;
    }

    public void UpdatePlace(GameObject side)
    {
        transform.position = side.transform.position + (side.transform.forward * (0.5f * transform.localScale.z));
        transform.rotation = side.transform.rotation;
        transform.Rotate(axis * _currentAngle, Space.Self);
    }

    public void ChangeAngle()
    {
        _currentAngle += angle;
        if (_currentAngle >= 360)
        {
            _currentAngle = 0;
        }
    }
}
