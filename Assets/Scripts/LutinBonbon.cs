using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinBonbon : MonoBehaviour, IInteractable
{
    public Animator animator;
    private PlayerMovement player;

    public void Interact()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.forward = direction;
    }

    void Start()
    {
        player = FindAnyObjectByType<PlayerMovement>();
    }

    void Update()
    {
        
    }
}
