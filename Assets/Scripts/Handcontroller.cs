using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Handcontroller : MonoBehaviour
{
    public InputActionReference gripAction;
    public InputActionReference triggerAction;

    private Animator animator;
    private SphereCollider sphereCollider;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!animator)
            return;

        float gripValue = gripAction.action.ReadValue<float>();
        float triggerValue = triggerAction.action.ReadValue<float>();

        animator.SetFloat("Grip", gripValue);
        animator.SetFloat("Trigger", triggerValue);

    }
}
