using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton : MonoBehaviour, IInteractable
{
    public int number;
    public AudioSource buttonPressedSound;

    public void Interact(Player player)
    {
        FindAnyObjectByType<CodeDeChiffres>().OnPress(number);
        if (buttonPressedSound != null)
        {
            buttonPressedSound.Play();
        }
    }
}
