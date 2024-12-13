using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour, IInteractable
{
    //public GameObject candy;

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        //candy.SetActive(true);
        DialogueTriggers.candyInHand = true;
        /*
        if (DialogueTriggers.instance)
        {
            if (!DialogueTriggers.instance.HasBonbon)
            {
                DialogueTriggers.instance.HasBonbon = true;
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
