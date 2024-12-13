using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Events
{
    [HideInInspector] public string name;
    [SerializeField] private UnityEvent onChange;

    public UnityEvent OnChange => onChange;
}
