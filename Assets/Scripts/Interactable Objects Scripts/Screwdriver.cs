using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screwdriver : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        Debug.Log("Screwdriver");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
