using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item2 // Value Type -- Stack
{
    public string itemName;
    public int itemID;

    public Item2(string name, int ID)
    {
        this.itemName = name;
        this.itemID = ID;
    }
}

public class Item3 // Reference Type -- Heap
{
    public string itemName;
    public int itemID;

    public Item3(string name, int ID)
    {
        this.itemName = name;
        this.itemID = ID;
    }

}

public class StructExample : MonoBehaviour
{
    Item2 smallShield;

    Item3 warAxe = new Item3("War Axe", 1);

    int age = 25;

    //VALUE TYPES -- store their own data // Fewer than 4 elements, Values do not change, No class inheritance 
    //bool, byte, char, double, float, int, long, struct

    string warAxeName = "Big Choppah";
    //REFERENCE TYPES -- stores a memory address where the data is stored
    //string, array, class, delegate

    private void Start()
    {
        smallShield.itemName = "Small Shield";
        smallShield.itemID = 2;

        Debug.Log($"War Axe current name is {warAxe.itemName}");
        ChangeValue(warAxe);
        Debug.Log($"War Axe current name after Change Value method is {warAxe.itemName}");

        Debug.Log($"Small Shield current name is {smallShield.itemName}");
        ChangeValue(smallShield);
        Debug.Log($"Small Shield current name after Change Value method is {smallShield.itemName}");
    }

    void ChangeValue(Item2 structItem) // value type
    {
        structItem.itemName = "Large Shield";
        Debug.Log(structItem.itemName);
    }

    void ChangeValue(Item3 classItem) // reference type
    {
        classItem.itemName = "Barbarian Axe";
    }
}
