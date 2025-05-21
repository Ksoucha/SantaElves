using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndMenu : MonoBehaviour
{
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
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
