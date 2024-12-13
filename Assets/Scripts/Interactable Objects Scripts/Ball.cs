using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IInteractable
{
    public GameObject ball;

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        ball.SetActive(true);
        DialogueTriggers.ballInHand = true;
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
