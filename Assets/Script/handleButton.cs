using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class LoadSceneOnButtonPress : MonoBehaviour
{
    public XRBaseInteractable interactableButton; // Référence au bouton XR Interactable
    public string sceneToLoad; // Nom de la scène à charger

    void Start()
    {
        // S'abonner à l'événement d'appui sur le bouton
        interactableButton.onSelectEntered.AddListener(OnButtonPressed);
    }

    void OnButtonPressed(XRBaseInteractor interactor)
    {
        // Charger la scène spécifiée
        SceneManager.LoadScene(sceneToLoad);
    }
}