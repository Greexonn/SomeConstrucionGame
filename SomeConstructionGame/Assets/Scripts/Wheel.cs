using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public GameObject wheelMesh;
    public WheelCollider wheel;

    public float motorPower;
    public float brakeTorque;

    void Start()
    {
        wheel.steerAngle = 90;

        //subscribe
        SimpleInputHandler.OnWheelTorque += ApplyTorque;
        SimpleInputHandler.OnBrake += ApplyBreakTorque;
    }

    void OnDestroy()
    {
        //unsubscribe
        SimpleInputHandler.OnWheelTorque -= ApplyTorque;
        SimpleInputHandler.OnBrake -= ApplyBreakTorque;
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

    public void ApplyBreakTorque(int value)
    {
        wheel.brakeTorque = brakeTorque * value;
    }
}
