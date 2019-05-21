using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructionController : MonoBehaviour
{
    [SerializeField]
    public List<LayerMask> layers;

    public GameObject currentPart;
    public GameObject currentPartPreview;

    public static ConstructionController instance;


    private GameObject _previewInstance;
    private UnitPreview _preview;
    private Side _targetSide;

    private float _extendAngle;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        //point events
        PointerController.OnPointStarted += PlacePreview;
        PointerController.OnPointUpdated += UpdatePreview;
        PointerController.OnPointEnded += RemovePreview;
        //attachment events
        SimpleInputHandler.OnClick += AttachPart;

        //
        SetLayer(1);

        //
        _extendAngle = 0;
    }

    void OnDestroy()
    {
        //point events
        PointerController.OnPointStarted -= PlacePreview;
        PointerController.OnPointUpdated -= UpdatePreview;
        PointerController.OnPointEnded -= RemovePreview;
        //attachment events
        SimpleInputHandler.OnClick -= AttachPart;
    }

    public void SetLayer(int id)
    {
        PointerController.instance.SetTargetLayer(layers[id]);
    }

    //
    //selection
    //
    public void SetCurrentPart(PartPrefab partObject)
    {
        currentPart = partObject.part;
        currentPartPreview = partObject.partPreview;
    }

    //
    //attachment controls
    //
    public void AttachPart()
    {
        if (_targetSide != null)
        {
            GameObject _part = Instantiate(currentPart, _previewInstance.transform.position, _previewInstance.transform.rotation);
            FixedJoint _joint = _part.GetComponent<FixedJoint>();
            if (_joint == null)
            {
                _joint = _part.GetComponentInChildren<FixedJoint>();
            }
            Rigidbody _anchor = _targetSide.body;
            //attach part
            _joint.connectedBody = _anchor;
            _targetSide.AttachObject();

            //reset
            _extendAngle = 0;
        }
    }


    //
    //preview controls
    //
    public void PlacePreview(GameObject side)
    {
        _targetSide = side.GetComponent<Side>();

        if (_targetSide != null)
        {
            _previewInstance = Instantiate(currentPartPreview, side.transform.position, side.transform.rotation);
            _preview = _previewInstance.GetComponent<UnitPreview>();
        }
    }

    public void UpdatePreview(GameObject side)
    {
        if (_preview != null)
        {
            _preview.UpdatePlace(side);
        }
    }

    public void RemovePreview(GameObject side)
    {
        _targetSide = null;

        if (_previewInstance != null)
        {
            Destroy(_previewInstance);
        }
    }
}
