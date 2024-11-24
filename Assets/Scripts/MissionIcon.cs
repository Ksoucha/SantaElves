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
}
