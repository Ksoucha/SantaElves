using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour, IInteractable
{
    public void Interact(Player player)
    {
        Debug.Log("Candy");
        player.candy.SetActive(true);
        DialogueTriggers.candyInHand = true;

        MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
        if (missionIcon != null)
        {
            missionIcon.ShowGreenMissionIcon();
        }
    }
}
