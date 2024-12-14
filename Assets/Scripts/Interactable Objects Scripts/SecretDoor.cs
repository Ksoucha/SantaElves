using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDoor : MonoBehaviour, IInteractable
{
    public GameObject openedSecretDoor;
    public GameObject closedSecretDoor;
    public AudioSource secretDoorSound;

    public void Interact(Player player)
    {
        Debug.Log("Secret Door");

        if (DialogueTriggers.giftedCandy == true)
        {
            secretDoorSound.Play();
            openedSecretDoor.SetActive(true);
            closedSecretDoor.SetActive(false);
            DialogueTriggers.secretDoorOpen = true;

            MissionIcon missionIcon = FindObjectOfType<MissionIcon>();
            if (missionIcon != null)
            {
                missionIcon.ShowGreenMissionIcon();
            }
        }
    }
}



