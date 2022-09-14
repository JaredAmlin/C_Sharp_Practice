using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    [Header("Customer Attributes")]
    public int customerID;
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;

    public Customer(int customerID, string firstName, string lastName, int age, string gender, string occupation)
    {
        this.customerID = customerID;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }
}
