using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer[] customers;

    public Customer customer1;
    public Customer customer2;
    public Customer customer3;

    // Start is called before the first frame update
    void Start()
    {
        customer1 = CreateCustomer(0, "John", "Harrison", 48, "Male", "Architect");
        customer2 = CreateCustomer(1, "Wendy", "Adams", 32, "Female", "Doctor");
        customer3 = CreateCustomer(2, "Roberta", "Gonzales", 27, "Female", "Biologist");
    }

    private Customer CreateCustomer(int customerID, string firstName, string lastName, int age, string gender, string occupation)
    {
        var customer = new Customer(customerID, firstName, lastName, age, gender, occupation);

        return customer;
    }
}
