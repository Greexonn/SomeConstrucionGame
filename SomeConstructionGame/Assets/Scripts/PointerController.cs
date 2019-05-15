using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PointerController : MonoBehaviour
{
    public static PointerController instance;

    //layers
    public LayerMask partLayer;
    public LayerMask sideLayer;
    //
    public float maxDistance;

    //delegates
    public delegate void PointAction(GameObject pointedObject);

    //public events
    public static event PointAction OnPointStarted;
    public static event PointAction OnPointUpdated;
    public static event PointAction OnPointEnded;

    // public UnityEvent<GameObject> OnPointStarted;
    // public UnityEvent<GameObject> OnPointUpdated;
    // public UnityEvent<GameObject> OnPointEnded;

    public static RaycastHit hitInfo;
    private LayerMask _targetLayer;

    //
    private GameObject _currentPointed;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
    }

    void Update()
    {
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out hitInfo, maxDistance, _targetLayer))
        {
            if (_currentPointed != hitInfo.collider.gameObject)
            {
                if (_currentPointed != null)
                    if (OnPointEnded != null)
                        OnPointEnded(_currentPointed);

                _currentPointed = hitInfo.collider.gameObject;
                if (OnPointStarted != null)
                    OnPointStarted(_currentPointed);
                if (OnPointUpdated != null)
                    OnPointUpdated(_currentPointed);
            }
            else 
            {
                if (_currentPointed != null)
                    OnPointUpdated.Invoke(_currentPointed);
            }
        }
        else
        {
            if (OnPointEnded != null)
                OnPointEnded(_currentPointed);
            
            _currentPointed = null;
        }
    }

    public void SetTargetLayer(LayerMask layer)
    {
        _targetLayer = layer;
    }
}
