using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon : Item
{
    public int attackPower;
    public float heftWeight;

    void ExampleMethod()
    {
        Debug.Log($"The name of this item is {itemName}");
    }
}
