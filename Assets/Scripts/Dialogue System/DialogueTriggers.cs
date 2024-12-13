using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggers : MonoBehaviour
{
    public static DialogueTriggers instance;
    public static bool batteryInHand = true;
    public bool giftedBattery = false;
    public bool talkedWithBiscuit = false;
    public bool talkedWithBonbon = false;
    public bool talkedWithChocolat = false;
    public bool talkedWithChocolatWithBonbon = false;
    public bool HasBonbon = false;
    public bool HasFoundMissingPiece = false;
    public bool HasScrewdriver = false;
    public bool HasFixedToy = false;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
