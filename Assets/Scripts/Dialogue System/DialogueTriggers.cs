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
    public static bool secretDoorOpen = false;
    public static bool wrenchInHand = false;
    public static bool brokenToyInHand = false;
    public static bool giftedToy = false;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
