using System.Linq;
using UnityEngine;

public class FreezeBuildings : MonoBehaviour
{
    void Start()
    {
        var buildingLayer = LayerMask.NameToLayer("Batiment");

        var buildings = FindGameObjectsWithLayer(buildingLayer);

        foreach (GameObject building in buildings)
        {
            var rigidbody = building.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            }
        }
    }

    GameObject[] FindGameObjectsWithLayer(int layer)
    {
        var allObjects = FindObjectsOfType<GameObject>();

        return allObjects.Where(obj => obj.layer == layer).ToArray();
    }
}

