using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrench : MonoBehaviour, IInteractable
{
    public GameObject wrench;

    public void Interact(Player player)
    {
        Debug.Log("Wrench");
        player.wrench.SetActive(true);
        DialogueTriggers.wrenchInHand = true;
        Destroy(wrench);

        MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
        if (missionIcon != null)
        {
            missionIcon.ShowGreenMissionIcon();
        }
    }
}
