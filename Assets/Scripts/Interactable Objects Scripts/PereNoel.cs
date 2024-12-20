using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PereNoel : MonoBehaviour, IInteractable
{
    public DialogueObject dialogueObject;
    public DialogueObject fixedToyDialogueObject;

    public void Interact(Player player)
    {
        Debug.Log("Pere Noel");
    }
}
