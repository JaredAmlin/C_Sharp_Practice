using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    [SerializeField] protected string branchName;
    protected string address;
    protected int cashInVault;

    protected void CheckBalance()
    {
        Debug.Log($"Checking balance at {branchName}");
    }

    protected void Withdrawl()
    {
        Debug.Log($"Withdrawling money from {branchName}");
    }

    protected void Deposit()
    {
        Debug.Log($"Depositing Money to {branchName}");
    }
}
