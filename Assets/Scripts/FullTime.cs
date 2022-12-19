using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTime : Employee
{
    public int salary;

    private void Start()
    {
        CalculateMonthlySalary();
    }

    public override void CalculateMonthlySalary()
    {
        int monthlySalary = salary / 12;
        Debug.Log(employeeName + " gets a monthy salary of " + monthlySalary);
    }
}


