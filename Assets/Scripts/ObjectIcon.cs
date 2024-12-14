using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Candy,
    Toy,
    Battery,
    Screwdriver
}

public class ObjectIcon : MonoBehaviour
{
    //public Image candy;
    //public Image toy;
    //public Image battery;
    //public Image screwdriver;
    public Dictionary<ItemType, Image> itemsImage;
    public AudioSource itemPop;

    public void ShowItemIcon(ItemType itemType)
    {
        itemsImage[itemType].gameObject.SetActive(true);
        itemPop.Play();
    }

    public void RemoveItemIcon(ItemType itemType)
    {
        itemsImage[itemType].gameObject.SetActive(false);
        itemPop.Play();
    }
}
