using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Player player)
    {
        Debug.Log("TOY");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
