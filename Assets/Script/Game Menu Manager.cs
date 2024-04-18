using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public Transform head;
    public float SpawnDistance = 2;

    public InputActionProperty showButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            // Active ou désactive le menu
            menu.SetActive(!menu.activeSelf);

            // Si le menu est activé, met en pause le jeu
            if (menu.activeSelf)
            {
                Time.timeScale = 0f; // Met en pause le temps
            }
            else
            {
                Time.timeScale = 1f; // Reprend la vitesse normale du temps
            }

            // Positionne le menu devant la tête du joueur avec une certaine distance
            menu.transform.position = head.position + head.forward * SpawnDistance;
        }

        // Fait tourner le menu pour qu'il fasse face à la tête du joueur
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }
}