using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IInteractable
{
    public GameObject bouleDeNoel;

    public void Interact(Player player)
    {
        Debug.Log("Ball");
        player.ball.SetActive(true);
        DialogueTriggers.ballInHand = true;
        Destroy(bouleDeNoel);
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
        }*/

        MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
        if (missionIcon != null)
        {
            missionIcon.ShowGreenMissionIcon();
        }
    }
}
