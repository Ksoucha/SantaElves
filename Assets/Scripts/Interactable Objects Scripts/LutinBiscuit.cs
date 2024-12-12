using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinBiscuit : MonoBehaviour
{
    public Animator animator;
    private Player player;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
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
