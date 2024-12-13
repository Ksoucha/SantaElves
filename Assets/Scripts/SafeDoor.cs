using DoorScript;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDoor : Door
{
    private bool doorOpened;

    void Start()
    {
        doorOpened = false;
    }

    private void OnMouseDown()
    {
        Invoke("RunCoroutine", 0f);
    }

    private void RunCoroutine()
    {
        StartCoroutine("OpenThatDoor");
    }

    private IEnumerator OpenThatDoor()
    {
        if (!doorOpened)
        {
            for (float i = 45f; i >= 0f; i -= 3f)
            {
                transform.localRotation = Quaternion.Euler(0f, -i, 0f);
                yield return new WaitForSeconds(0.1f);
            }
            doorOpened = false;
        }
    }

    public override void Unlock()
    {
        Debug.Log("Safe Door Unlocked!");
        Invoke("RunCoroutine", 0f);
        Destroy(this.gameObject);
    }
}
