using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinBiscuit : MonoBehaviour, IInteractable
{
    public Animator animator;
    private PlayerMovement player;

    void Start()
    {
        player = FindAnyObjectByType<PlayerMovement>();
    }

    void Update()
    {
        
    }

    public void Interact()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.forward = direction;
    }
}
