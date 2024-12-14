using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour, IInteractable
{
    public DialogueObject dialogueObject;
    public GameObject toy;

    public void Interact(Player player)
    {
        player.brokenToy.SetActive(true);
        DialogueTriggers.brokenToyInHand = true;
        Destroy(toy);

        /*DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
        if (dialogueUI != null)
        {
            dialogueUI.ShowDialogue(dialogueObject);
            
            if (DialogueTriggers.instance)
            {
                if (DialogueTriggers.instance.HasScrewdriver && !DialogueTriggers.instance.HasFixedToy)
                {
                    DialogueTriggers.instance.HasFixedToy = true;
                    MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
                    if (missionIcon != null)
                    {
                        missionIcon.ShowGreenMissionIcon();
                    }
                }
            }
        }*/
    }
}
