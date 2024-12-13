using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screwdriver : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        /*
        if (DialogueTriggers.instance)
        {
            if (DialogueTriggers.instance.HasFoundMissingPiece && !DialogueTriggers.instance.HasScrewdriver)
            {
                DialogueTriggers.instance.HasScrewdriver = true;
                MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
                if (missionIcon != null)
                {
                    missionIcon.ShowGreenMissionIcon();
                }
            }
        }
        */
        
        Debug.Log("Screwdriver");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
