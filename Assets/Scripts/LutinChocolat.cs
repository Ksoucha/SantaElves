using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinChocolat : MonoBehaviour
{
    public Animator animator;
    private Player player;

    public void Interact()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.forward = direction;
    }

    void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    void Update()
    {
        
    }
}
