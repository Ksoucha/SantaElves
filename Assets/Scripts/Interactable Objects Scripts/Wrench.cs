using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrench : MonoBehaviour, IInteractable
{
    //public GameObject wrench;

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        //wrench.SetActive(true);
        DialogueTriggers.wrenchInHand = true;
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
}
