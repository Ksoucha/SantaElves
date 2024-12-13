using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private Door raycastedObj;

    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;
    
    private bool doOnce;

    private const string interactableTag = "InteractiveObject";

    private void Update()
    {

       if (Input.GetKeyDown(openDoorKey))
       {
           raycastedObj.PlayAnimation();      
       }

    }


}
