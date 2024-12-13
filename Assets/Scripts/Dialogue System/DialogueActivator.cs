using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogueObject firstDialogueObject;
    [SerializeField] private DialogueObject secondDialogueObject;
    [SerializeField] private DialogueObject thirdDialogueObject;
    [SerializeField] private DialogueObject fourthDialogueObject;
    [SerializeField] private DialogueObject fifthDialogueObject;
    [SerializeField] private DialogueObject sixthDialogueObject;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            player.interactable = this;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            if (player.interactable is DialogueActivator dialogueActivator && dialogueActivator == this)
            {
                player.interactable = null;
            }
        }
    }


    public void Interact(Player player)
    {
        player.DialogueUI.ShowDialogue(firstDialogueObject);
    }

}
