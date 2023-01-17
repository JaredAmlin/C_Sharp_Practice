using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;
    public string itemName;
    public string itemDescription;
    public Sprite ItemIcon;
    public int buffValue;

    public enum ItemType
    {
        Weapon, Consumable, Armor, Currency, Generic
    }

    public ItemType itemType;

    public static int totalItems;

    public static string Brand;

    public Item()
    {
        Debug.Log("instance members have been initialized");
    }

    public Item(int itemID, string itemName, string itemDescription)
    {
        this.itemID = itemID;
        this.itemName = itemName;
        this.itemDescription = itemDescription;

        totalItems++;
        Debug.Log("There are " + totalItems + " total items in your inventory.");
    }

    static Item()
    {
        Brand = "Best Items";
        Debug.Log("static members have been initialized");
        Debug.Log($"The Brand of these items is {Brand}");
    }

    public void ItemAction()
    {
        switch(itemType)
        {
            case ItemType.Weapon:
                Debug.Log($"This is a {itemType}");
                break;
            case ItemType.Armor:
                Debug.Log($"This is {itemType}");
                break;
            case ItemType.Consumable:
                Debug.Log($"This is a {itemType}");
                break;
            case ItemType.Currency:
                Debug.Log($"This is {itemType}");
                break;
            default: Debug.Log("There is no Action for this itemAction");
                break;
        }
    }
}
