using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour, IInteractable
{
    //public DialogueObject dialogueObject;

    public void Interact(Player player)
    {
        Debug.Log("Battery");
        player.battery.SetActive(true);
        DialogueTriggers.batteryInHand = true;

        /*DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
        if (dialogueUI != null)
        {
            //dialogueUI.ShowDialogue(dialogueObject);
            if (DialogueTriggers.instance)
            {
                if (!DialogueTriggers.batteryInHand)
                {
                    MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
                    if (missionIcon != null)
                    {
                        missionIcon.ShowGreenMissionIcon();
                    }
                }
            }
        }*/

        MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
        if (missionIcon != null)
        {
            missionIcon.ShowGreenMissionIcon();
        }
    }
}
