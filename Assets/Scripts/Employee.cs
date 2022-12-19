using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{
    public string companyName, employeeName;

    public abstract void CalculateMonthlySalary();
}       

