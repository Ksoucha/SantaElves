using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    public AudioMixerGroup masterVolumeGroup;
    public Slider volumeSlider;
    public Slider mouseSlider;

    public GameObject optionsMenu;
    public GameObject pauseMenu;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnMasterVolumeChanged()
    {
        masterVolumeGroup.audioMixer.SetFloat("Volume", volumeSlider.value);
    }

    public void OnBackButtonClicked()
    {
        if (pauseMenu)
        {
            if (pauseMenu.activeInHierarchy)
            {
                optionsMenu.SetActive(false);
                pauseMenu.SetActive(true);
            }
            else
            {
                optionsMenu.SetActive(false);
            }
        }
        else
        {
            optionsMenu.SetActive(false);
        }
    }

    public void OnMouseSensitivityChanged()
    {
        if (PlayerSettings.instance)
        {
            Debug.Log("sensitivity");
            PlayerSettings.instance.mouseSensitivity = mouseSlider.value;
        }
    }
}
