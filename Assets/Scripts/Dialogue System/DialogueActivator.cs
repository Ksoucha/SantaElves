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
    [SerializeField] private DialogueObject seventhDialogueObject;
    [SerializeField] private DialogueObject eightDialogueObject;
    [SerializeField] private DialogueObject ninthDialogueObject;
    [SerializeField] private DialogueObject tenthDialogueObject;

    

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
        if (DialogueTriggers.brokenToyInHand == true)
        {
            player.DialogueUI.ShowDialogue(tenthDialogueObject);
        }
        else if (DialogueTriggers.wrenchInHand == true)
        {
            player.DialogueUI.ShowDialogue(ninthDialogueObject);
        }
        else if (DialogueTriggers.secretDoorOpen == true)
        {
            player.DialogueUI.ShowDialogue(eightDialogueObject);
        }
        else if (DialogueTriggers.giftedCandy == true)
        {
            player.DialogueUI.ShowDialogue(seventhDialogueObject);
        }
        else if (DialogueTriggers.candyInHand == true)
        {
            player.DialogueUI.ShowDialogue(sixthDialogueObject);
            DialogueTriggers.giftedCandy = true;
        }
        else if (DialogueTriggers.giftedBall == true)
        {
            player.DialogueUI.ShowDialogue(fifthDialogueObject);
        }
        else if (DialogueTriggers.ballInHand == true)
        {
            //DialogueTriggers.giftedBattery = false;
            player.DialogueUI.ShowDialogue(fourthDialogueObject);
            player.ball.SetActive(false);
            DialogueTriggers.giftedBall = true;
        }
        else if (DialogueTriggers.giftedBattery == true)
        {
            player.DialogueUI.ShowDialogue(thirdDialogueObject);
            DialogueTriggers.giftedBattery = false;
        }
        else if (DialogueTriggers.batteryInHand == true)
        {
            player.DialogueUI.ShowDialogue(secondDialogueObject);
            player.battery.SetActive(false);
            DialogueTriggers.batteryInHand = false;
            DialogueTriggers.giftedBattery = true;
        }
        else
        {
            player.DialogueUI.ShowDialogue(firstDialogueObject);
        }
    }
}
