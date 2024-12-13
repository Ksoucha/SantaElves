using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PereNoel : MonoBehaviour, IInteractable
{
    public DialogueObject dialogueObject;
    public DialogueObject fixedToyDialogueObject;

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        Debug.Log("Pere Noel");
        DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
        if (dialogueUI != null)
        {
            /*
            if (DialogueTriggers.instance != null)
            {
                if (DialogueTriggers.instance.HasFixedToy)
                {
                    dialogueUI.ShowDialogue(fixedToyDialogueObject);
                    //End Game
                }
                else
                {
                    dialogueUI.ShowDialogue(dialogueObject);
                }
            }
            */
        }
    }
}
