using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeControl : MonoBehaviour
{
    public float angle;
    public float step;

    private float _currentAngle;
    private HingeJoint _joint;
    private JointSpring _spring;

    void Start()
    {
        _currentAngle = 0;
        _joint = GetComponent<HingeJoint>();
        _spring = _joint.spring;

        angle = _joint.limits.max;

        //subscribe
        SimpleInputHandler.OnTurn += ApplyAngle;
    }

    public void OnDestroy()
    {
        //unsubscribe
        SimpleInputHandler.OnTurn -= ApplyAngle;
    }

    public void ApplyAngle(int value)
    {
        if ((value > 0) && ((_currentAngle + step) <= angle))
            _currentAngle += step * value;
        else if ((value < 0) && ((_currentAngle - step) >= -angle))
            _currentAngle += step * value;

        _spring.targetPosition = _currentAngle;
        _joint.spring = _spring;
    }
}
