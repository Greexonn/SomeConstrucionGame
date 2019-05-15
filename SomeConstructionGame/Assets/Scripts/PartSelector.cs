using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSelector : MonoBehaviour
{
    [SerializeField]
    public List<PartPrefab> parts;

    void Start()
    {
        SelectPart(0);
    }

    public void SelectPart(int partID)
    {
        ConstructionController.instance.SetCurrentPart(parts[partID]);
    }
}

[System.Serializable]
public struct PartPrefab
{
    public GameObject part;
    public GameObject partPreview;
}
