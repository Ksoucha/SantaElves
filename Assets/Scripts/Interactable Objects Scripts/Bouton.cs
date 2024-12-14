using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton : MonoBehaviour, IInteractable
{
    public int number;
    public CodeDeChiffres codeDeChiffres;

    public void Interact(Player player)
    {
        if (!codeDeChiffres)
        {
            codeDeChiffres = FindAnyObjectByType<CodeDeChiffres>();
        }

        codeDeChiffres.OnPress(number);
    }
}
