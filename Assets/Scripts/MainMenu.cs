using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;

    public void OnButtonStart()
    {
        SceneManager.LoadScene("Transition");
    }

    public void OnButtonOptions()
    {
        optionsMenu.SetActive(true);
    }

    public void OnButtonExit()
    {
#if UNITY_EDITOR

        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#else
        Application.Quit();

#endif
        
    }
}
