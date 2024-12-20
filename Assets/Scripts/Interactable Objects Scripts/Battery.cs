using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour, IInteractable
{
    public void Interact(Player player)
    {
        Debug.Log("Battery");
        player.battery.SetActive(true);
        DialogueTriggers.batteryInHand = true;

        MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
        if (missionIcon != null)
        {
            missionIcon.ShowGreenMissionIcon();
        }
    }
}
