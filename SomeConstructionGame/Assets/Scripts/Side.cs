using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : MonoBehaviour
{
    public LayerMask sideLayer;

    public bool isLocked;

    public Rigidbody body;

    void Start()
    {
        sideLayer = LayerMask.GetMask("Side");

        body = GetComponentInParent<Rigidbody>();

        //attach to other object
        RaycastHit _hitInfo;
        if (Physics.Raycast(transform.position, transform.forward, out _hitInfo, 0.1f, sideLayer))
        {
            Side _side = _hitInfo.collider.gameObject.GetComponent<Side>();
            if (_side != null && _side != this)
            {
                FixedJoint _joint = _side.body.gameObject.AddComponent<FixedJoint>();
                FixedJoint _currentJoint = body.gameObject.GetComponent<FixedJoint>();
                //configurate joint
                _joint.enableCollision = true;
                _joint.enablePreprocessing = false;
                _joint.breakForce = _currentJoint.breakForce;
                _joint.breakTorque = _currentJoint.breakTorque;
                //set body
                _joint.connectedBody = body;
            }
        }
    }

    public void AttachObject()
    {
        isLocked = true;
    }
}
