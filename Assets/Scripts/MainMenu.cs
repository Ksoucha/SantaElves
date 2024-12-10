using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

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
        Application.Quit();
    }
}
