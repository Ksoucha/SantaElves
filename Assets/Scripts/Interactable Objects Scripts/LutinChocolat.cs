using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinChocolat : Lutin
{
    DialogueObject bonbonDialogue;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    public override void Interact()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.forward = direction;
    }

    public override void Interact(Player player)
    {
        Debug.Log("Lutin Chocolat");

        /*
        if (DialogueTriggers.instance)
        {
            if (DialogueTriggers.instance.HasBonbon && DialogueTriggers.instance.talkedWithChocolatWithBonbon)
            {
                DialogueTriggers.instance.talkedWithChocolatWithBonbon = true;
                DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
                if (dialogueUI != null)
                {
                    dialogueUI.ShowDialogue(bonbonDialogue);
                }
                MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
                if (missionIcon != null)
                {
                    missionIcon.ShowGreenMissionIcon();
                }
            }
            else if (DialogueTriggers.instance.talkedWithBiscuit)
            {
                DialogueTriggers.instance.talkedWithChocolat = true;
                DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
                if (dialogueUI != null)
                {
                    dialogueUI.ShowDialogue(dialogueObject);
                }
            }
        }
        */
    }
}
