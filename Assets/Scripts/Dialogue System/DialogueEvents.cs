using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DialogueEvents : MonoBehaviour
{
    [SerializeField] private DialogueObject dialogueObject;
    [SerializeField] private Event[] events;

    public Event[] Events => events;

    public void OnValidate()
    {
        if (dialogueObject == null)
        {
            return;
        }
    }
}
