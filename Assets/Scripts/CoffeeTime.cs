using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTime : MonoBehaviour
{   
    private float[] _prices = { 2.3445f, 3.2365f, 5.6578f, 2.2232f, 1.2186f, 3.3395f };
    private float _totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        _totalAmount = _prices[0] + _prices[1] + _prices[2] + _prices[3] + _prices[4] + _prices[5];
        _totalAmount = Mathf.Round(_totalAmount * 100) / 100;

        Debug.Log(_totalAmount);
    }
}
