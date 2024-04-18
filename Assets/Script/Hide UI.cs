using UnityEngine;
using UnityEngine.UI;

public class HideUI : MonoBehaviour
{
    public GameObject uiToHide; 

   
    public void HideUIAndResume()
    {
        
        if (uiToHide != null)
        {
            
            uiToHide.SetActive(false);
        }

        
        Time.timeScale = 1f;

        Debug.Log("UI hidden and game resumed.");
    }
}