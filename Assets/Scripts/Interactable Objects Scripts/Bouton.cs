using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton : MonoBehaviour, IInteractable
{
    public int number;

    public void Interact(Player player)
    {
        FindAnyObjectByType<CodeDeChiffres>().OnPress(number);
    }
}
