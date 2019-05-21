using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float blastPower;
    public float maxDistance;
    public LayerMask layer;

    public Transform blastOrigin;

    private RaycastHit _hitInfo;
    private Vector3 _hitPos;
    private LineRenderer _renderer;

    void Start()
    {
        _renderer = GetComponent<LineRenderer>();
        _renderer.enabled = false;

        SimpleInputHandler.OnFire += Blast;
    }

    void OnDestroy()
    {
        SimpleInputHandler.OnFire -= Blast;
    }

    public void Blast()
    {
        if (Physics.Raycast(blastOrigin.position, blastOrigin.forward, out _hitInfo, maxDistance, layer))
        {
            _hitPos = _hitInfo.point;

            StartCoroutine(DrawBlast());

            Rigidbody _hit = _hitInfo.collider.attachedRigidbody;

            _hit?.AddExplosionForce(blastPower, _hitPos, 5f);
        }
        else
        {
            _hitPos = blastOrigin.position + (blastOrigin.forward * maxDistance);
            StartCoroutine(DrawBlast());
        }
    }

    public IEnumerator DrawBlast()
    {
        _renderer.enabled = true;

        _renderer.SetPosition(0, blastOrigin.position);
        _renderer.SetPosition(1, _hitPos);

        yield return new WaitForSeconds(0.2f);

        _renderer.enabled = false;
    }
}
