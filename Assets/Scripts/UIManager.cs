using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //singelton UI Manager
    private static UIManager _instance;

    private int _points;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("The UI Manager is NULL.");
                GameObject uiManager = new GameObject("UIManager");
                uiManager.AddComponent<UIManager>();
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void UpdatePoints(int points)
    {
        _points += points;
        Debug.Log("The current point total is " + _points);
    }
}
