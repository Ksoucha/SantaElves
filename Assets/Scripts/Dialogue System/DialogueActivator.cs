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

    public MissionIcon missionIcon;

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
            player.wrench.SetActive(false);
            missionIcon.ShowRedMissionIcon();
        }
        else if (DialogueTriggers.secretDoorOpen == true)
        {
            player.DialogueUI.ShowDialogue(eightDialogueObject);
        }
        else if (DialogueTriggers.giftedCandy == true)
        {
            player.DialogueUI.ShowDialogue(seventhDialogueObject);
            missionIcon.ShowRedMissionIcon();
        }
        else if (DialogueTriggers.candyInHand == true)
        {
            player.DialogueUI.ShowDialogue(sixthDialogueObject);
            player.candy.SetActive(false);
            DialogueTriggers.giftedCandy = true;
            missionIcon.ShowRedMissionIcon();
        }
        else if (DialogueTriggers.giftedBall == true)
        {
            player.DialogueUI.ShowDialogue(fifthDialogueObject);
            missionIcon.ShowRedMissionIcon();
        }
        else if (DialogueTriggers.ballInHand == true)
        {
            player.DialogueUI.ShowDialogue(fourthDialogueObject);
            player.ball.SetActive(false);
            DialogueTriggers.giftedBall = true;
            missionIcon.ShowRedMissionIcon();
        }
        else if (DialogueTriggers.giftedBattery == true)
        {
            player.DialogueUI.ShowDialogue(thirdDialogueObject);
            missionIcon.ShowRedMissionIcon();
        }
        else if (DialogueTriggers.batteryInHand == true)
        {
            player.DialogueUI.ShowDialogue(secondDialogueObject);
            player.battery.SetActive(false);
            DialogueTriggers.giftedBattery = true;
            missionIcon.ShowRedMissionIcon();
        }
        else
        {
            player.DialogueUI.ShowDialogue(firstDialogueObject);
        }
    }
}
