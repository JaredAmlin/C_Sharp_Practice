using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FederalCreditUnion : Bank
{
    protected int avaiableMoneyToLend;

    protected void ApproveLending()
    {
        Debug.Log("You are awarded a loan!");
    }
}
