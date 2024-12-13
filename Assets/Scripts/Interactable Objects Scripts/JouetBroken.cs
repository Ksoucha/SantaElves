using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JouetBroken : MonoBehaviour, IInteractable
{
    public DialogueObject dialogueObject;
    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
        if (dialogueUI != null)
        {
            dialogueUI.ShowDialogue(dialogueObject);
            /*
            if (DialogueTriggers.instance)
            {
                if (!DialogueTriggers.instance.HasFoundMissingPiece)
                {
                    DialogueTriggers.instance.HasFoundMissingPiece = true;
                    MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
                    if (missionIcon != null)
                    {
                        missionIcon.ShowGreenMissionIcon();
                    }
                }
            
            }
            */
        }
    }

}
