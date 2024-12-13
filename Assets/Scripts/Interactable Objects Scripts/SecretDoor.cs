using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDoor : MonoBehaviour
{

    public Collider clickObject;
    public Animation anim;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _opened;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Click();
        }
    }

    private void Click()
    {
        if (!clickObject) return;
        if (!anim) return;

        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out _hit))
        {
            if (_hit.collider == clickObject)
            {
                if (_opened)
                {
                    anim.Play("doorClose");
                    _opened = false;
                }
                else
                {
                    anim.Play("doorOpen");
                    _opened = true;
                }

            }
        }
    }
}
    /*[SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;
    private Animator doorAnim;
    [SerializeField] private Animation doorOpen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            if (Input.GetKeyDown(openDoorKey))
            {
                doorAnim.Play("DoorOpen", 0, 0);
            }
        }
    }

    /*public void Interact(Player player)
    {

        Debug.Log("Secret Door");

        //if (DialogueTriggers.giftedCandy == true)
        //{

            doorAnim.Play("DoorOpen", 0, 0.0f);

        //}

    }*/

