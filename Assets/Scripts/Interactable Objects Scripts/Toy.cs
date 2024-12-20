using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour, IInteractable
{
    public GameObject toy;

    void Start()
    {
        //this.enabled = false;
    }

    public void Interact(Player player)
    {
        player.brokenToy.SetActive(true);
        DialogueTriggers.brokenToyInHand = true;
        Destroy(toy);

        MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
        if (missionIcon != null)
        {
            missionIcon.ShowGreenMissionIcon();
        }
    }
}
