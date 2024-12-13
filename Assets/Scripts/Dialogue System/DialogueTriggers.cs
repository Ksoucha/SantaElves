using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggers : MonoBehaviour
{
    public static DialogueTriggers instance;
    public static bool batteryInHand = false;
    public static bool giftedBattery = false;
    public static bool ballInHand = false;
    public static bool giftedBall = false;
    public static bool candyInHand = false;
    public static bool giftedCandy = false;
    public bool secretDoorOpen = false;
    public bool wrenchInHand = false;
    public bool brokenToyInHand = false;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
