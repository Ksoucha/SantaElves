using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour, IInteractable
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

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
