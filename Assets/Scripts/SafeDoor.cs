using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDoor : MonoBehaviour
{
    private bool doorOpened;
    private bool coroutineAllowed;
    void Start()
    {
        doorOpened = false;
        coroutineAllowed = false;
        
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
        coroutineAllowed = false;
        if (!doorOpened)
        {
            for (float i = 45f; i >= 0f; i -= 3f)
            {
                transform.localRotation = Quaternion.Euler(0f, -i, 0f);
                yield return new WaitForSeconds(0f);
            }
            doorOpened = false;
        }
        coroutineAllowed = false;
    }
}
