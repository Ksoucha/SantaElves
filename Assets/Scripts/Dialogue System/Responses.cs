using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Responses
{

    [SerializeField] private string reponseText;
    [SerializeField] private DialogueObject dialogueObject;

    public string ResponseText => reponseText;

    public DialogueObject DialogueObject => dialogueObject;

}
