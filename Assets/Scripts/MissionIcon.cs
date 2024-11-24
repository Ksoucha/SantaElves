using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionIcon : MonoBehaviour
{
    public Image redHat;
    public Image greenHat;

    void Start()
    {
        redHat = GetComponent<Image>();
        redHat.enabled = true;
    }

    void Update()
    {
        
    }

    internal void ShowGreenMissionIcon()
    {
        greenHat.enabled = true;
        redHat.enabled = false;
    }

    internal void ShowRedMissionIcon()
    {
        redHat.enabled = true;
        greenHat.enabled = false;
    }
}
