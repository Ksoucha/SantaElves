using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionIcon : MonoBehaviour
{
    public Image redHat;
    public Image greenHat;
    public AudioSource greenHatPop;

    void Start()
    {
        ShowRedMissionIcon();
    }

    internal void ShowGreenMissionIcon()
    {
        greenHat.enabled = true;
        redHat.enabled = false;
        greenHatPop.Play();
    }

    internal void ShowRedMissionIcon()
    {
        redHat.enabled = true;
        greenHat.enabled = false;
    }
}
