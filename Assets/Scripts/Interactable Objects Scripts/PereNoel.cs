using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PereNoel : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        Debug.Log("Pere Noel");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
