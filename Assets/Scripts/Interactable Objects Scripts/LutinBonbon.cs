using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinBonbon : Lutin
{
    void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    public override void Interact()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.forward = direction;
    }

    public override void Interact(Player player)
    {
        Debug.Log("Lutin Bonbon");
        /*
        if (DialogueTriggers.instance)
        {
            if (DialogueTriggers.instance.HasFoundMissingPiece && !DialogueTriggers.instance.talkedWithBonbon)
            {
                DialogueTriggers.instance.talkedWithBonbon = true;
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
