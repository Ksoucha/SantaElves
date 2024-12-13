using DoorScript;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDeChiffres : MonoBehaviour
{
    public int[] code;
    public AudioSource succeedSound;
    public AudioSource failSound;
    
    [SerializeField] private Door door;
    int currentIndex;
    private bool isFinished;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

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
                /*
                isFinished = true;
                if (door != null)
                {
                    door.Unlock();
                }
                if (succeedSound != null)
                {
                    succeedSound.Play();
                }
                */
            }
        }
        else
        {
            currentIndex = 0;
            if (failSound != null)
            {
                failSound.Play();
            }
        }
    }
}
