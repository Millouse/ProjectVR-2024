using System.Collections.Generic;
using UnityEngine;

public class ActivationRigidbodyOnCollision : MonoBehaviour
{
    [SerializeField] private List<Rigidbody> childsRigidBody = new List<Rigidbody>();

    void Start()
    {
        // Assurez-vous que le composant Rigidbody est attaché au GameObject
        foreach (var childRb in childsRigidBody)
        {
            // childRb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    // Cette méthode est appelée lorsqu'un autre collider entre en collision avec ce collider
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hého on rentre du lboulot");
        // Vérifiez si la collision est avec un objet qui a un Rigidbody
        if (collision.gameObject.name == "Boule")
        {
            // Activez le Rigidbody
            Debug.Log("COUCOU JE SUIS BIEN DANS LA BOUCLE");
            foreach (var childRb in childsRigidBody)
            {
                childRb.constraints = RigidbodyConstraints.None;
            }
        }
    }
}