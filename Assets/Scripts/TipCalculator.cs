using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //bill is $40
    //Tip is 20% or based on what the user wants
    //total amount
    public int bill = 40;
    public float tip = 20.0f;
    public float totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        //int a = 5;
        //int b = 10;
        //int total = 0;
        //total = a + b;
        //your bill is: and your tip amount is: so you owe: totalAmount

        float tipAmount = bill * (tip / 100);
        totalAmount = bill + tipAmount;

        Debug.Log("Your bill for dinner is: " + bill + " and your tip amount is: " + tipAmount + " so you owe " + totalAmount);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
