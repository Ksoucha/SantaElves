using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour, IInteractable
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
            */
        }
        Debug.Log("TOY");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
