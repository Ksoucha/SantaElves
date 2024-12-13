using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour, IInteractable
{
    public DialogueObject dialogueObject;
    public GameObject battery;

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        battery.SetActive(true);
        DialogueTriggers.batteryInHand = true;
        DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
        if (dialogueUI != null)
        {
            //dialogueUI.ShowDialogue(dialogueObject);
            if (DialogueTriggers.instance)
            {
                if (!DialogueTriggers.batteryInHand)
                {
                    //DialogueTriggers.batteryInHand = true;
                    //battery.SetActive(true);
                    //DialogueTriggers.instance.HasFoundMissingPiece = true;
                    MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
                    if (missionIcon != null)
                    {
                        missionIcon.ShowGreenMissionIcon();
                    }
                }
            }
        }
    }
}
