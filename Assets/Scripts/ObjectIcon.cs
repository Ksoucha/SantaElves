using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectIcon : MonoBehaviour
{
    public Image candy;
    public Image toy;
    public Image battery;
    public Image screwdriver;

    void Start()
    {
        candy = GetComponent<Image>();
        toy = GetComponent<Image>();
        battery = GetComponent<Image>();
        screwdriver = GetComponent<Image>();
    }

    void Update()
    {
        
    }
}
