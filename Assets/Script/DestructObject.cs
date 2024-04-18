using UnityEngine;

namespace Script
{
    public class DestructObject : MonoBehaviour
    {
        public GameObject normalObject;
        public GameObject fracturedObject;
    
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Destructive"))
            {
                normalObject.SetActive(false);
                fracturedObject.SetActive(true);
            }
        }
    }
}
