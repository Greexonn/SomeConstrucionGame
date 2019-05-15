using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public GameObject wheelMesh;
    public WheelCollider wheel;

    public float motorPower;

    void Start()
    {
        wheel.steerAngle = 90;

        //subscribe
        SimpleInputHandler.OnWheelTorque += ApplyTorque;
    }

    void OnDestroy()
    {
        SimpleInputHandler.OnWheelTorque -= ApplyTorque;
    }

    void Update()
    {
        Vector3 _wheelPos;
        Quaternion _wheelRot;
        wheel.GetWorldPose(out _wheelPos, out _wheelRot);
        wheelMesh.transform.SetPositionAndRotation(_wheelPos, _wheelRot);
    }

    public void ApplyTorque(int value)
    {
        wheel.motorTorque = motorPower * value;
    }
}
