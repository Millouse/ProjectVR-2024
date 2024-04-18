using UnityEngine;

public class QuitGameManager : MonoBehaviour
{
    
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit(); 
    }
}