using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTime : Employee
{
    public int hoursWorked, hourlyRate;

    private void Start()
    {
        CalculateMonthlySalary();
    }

    public override void CalculateMonthlySalary()
    {
        int monthySalary = hourlyRate * hoursWorked;
        Debug.Log(employeeName + "gets a salary this month of " + monthySalary);
    }
}
