using DoorScript;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDeChiffres : MonoBehaviour
{
    public int[] code;
    public AudioSource succeedSound;
    public MissionIcon missionIcon;
    
    [SerializeField] private Door door;
    int currentIndex = 0;
    private bool isFinished = false;

    internal void OnPress(int number)
    {
        Debug.Log(number);
        if (isFinished)
            return;

        if (code[currentIndex] == number)
        {
            currentIndex++;
            if (currentIndex == code.Length)
            {
                isFinished = true;
                if (door != null)
                {
                    door.Unlock();
                    missionIcon.ShowRedMissionIcon();
                }
                if (succeedSound != null)
                {
                    succeedSound.Play();
                }   
            }
        }
        else
        {
            currentIndex = 0;
            Debug.Log("Failed");
        }
    }
}
