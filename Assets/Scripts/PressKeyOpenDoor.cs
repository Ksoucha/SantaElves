using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyOpenDoor : MonoBehaviour
{
    //public GameObject Instruction;
    public GameObject AnimeObject;
    public GameObject ThisTrigger;
    public AudioSource DoorOpenSound;
    public bool Action = false;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            //Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        //Instruction.SetActive(false);
        Action = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Action == true)
            {
                //Instruction.SetActive(false);
                AnimeObject.GetComponent<Animator>().Play("DoorOpen");
                ThisTrigger.SetActive(false);
                DoorOpenSound.Play();
                Action = false;
            }
        }

    }
}
