using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDeChiffres : MonoBehaviour, IInteractable
{
    public int[] code;
    public AudioSource succeedSound;
    public AudioSource failSound;
    public GameObject key;

    int currentIndex;
    private bool isFinished;

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        key.SetActive(false);
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
                key.SetActive(true);
                succeedSound.Play();
            }
        }
        else
        {
            currentIndex = 0;
            failSound.Play();
        }
    }
}
