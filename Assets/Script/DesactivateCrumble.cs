using System.Collections;
using UnityEngine;

namespace Script
{
    public class DesactivateCrumble : MonoBehaviour
    {
        void Update()
        {
            if (!this.gameObject.activeSelf) return;
            foreach (Transform child in transform)
            {
                StartCoroutine(DesactivatePieceOfBuilding(child));
            }
        }

        IEnumerator DesactivatePieceOfBuilding(Transform child)
        {
            yield return new WaitForSeconds(10.0f);
            child.gameObject.SetActive(false);
        }
    }
}
