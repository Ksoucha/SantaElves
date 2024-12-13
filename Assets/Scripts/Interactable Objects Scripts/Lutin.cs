using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lutin : MonoBehaviour, IInteractable
{
    public DialogueObject dialogueObject;
    public float moveSpeed = 2;
    public Transform waypoint1;
    public Transform waypoint2;

    Vector3 originalPosition;
    public Animator animator;
    protected Player player;

    public virtual void Interact()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.forward = direction;
    }

    void Start()
    {
        originalPosition = transform.position;
        //StartCoroutine(BiscuitCoroutine());
        player = FindAnyObjectByType<Player>();
    }

    IEnumerator BiscuitCoroutine()
    {
        yield return new WaitForSeconds(2);

        animator.SetBool("IsWalking", true);
        transform.forward = (waypoint1.position - transform.position).normalized;
        while (Vector3.Distance(transform.position, waypoint1.position) > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint1.position, moveSpeed * Time.deltaTime);
            yield return null;
        }
        animator.SetBool("IsWalking", false);

        yield return new WaitForSeconds(2);

        animator.SetTrigger("Dance");

        yield return new WaitForSeconds(2);

        animator.SetBool("IsWalking", true);
        transform.forward = (waypoint2.position - transform.position).normalized;
        while (Vector3.Distance(transform.position, waypoint2.position) > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint2.position, moveSpeed * Time.deltaTime);
            yield return null;
        }
        animator.SetBool("IsWalking", false);

        yield return new WaitForSeconds(2);

        animator.SetBool("IsWalking", true);
        transform.forward = (originalPosition - transform.position).normalized;
        while (Vector3.Distance(transform.position, originalPosition) > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
        animator.SetBool("IsWalking", false);
    }

    public virtual void Interact(Player player)
    {
        DialogueUI dialogueUI = FindObjectOfType<DialogueUI>();
        if (dialogueUI != null)
        {
            dialogueUI.ShowDialogue(dialogueObject);
        }
        Debug.Log("Lutin");
    }
}
