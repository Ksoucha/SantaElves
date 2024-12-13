using DoorScript;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDeChiffres : MonoBehaviour
{
    public int[] code;
    //public AudioSource succeedSound;
    //public AudioSource failSound;
    //public GameObject key;
    
    [SerializeField] private Door door;
    int currentIndex;
    private bool isFinished;

    void Start()
    {
        //key.SetActive(false);
    }

    void Update()
    {
        
    }

    internal void OnPress(int number)
    {
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
                }
                //key.SetActive(true);
                //succeedSound.Play();
            }
        }
        else
        {
            currentIndex = 0;
            //failSound.Play();
        }
    }
}
