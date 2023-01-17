using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //singleton initialization
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            //return game manager instance
            if (_instance == null)
                Debug.LogError("The Game Manager is NULL.");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        InputManager.Instance.GetInput();
    }

    public void GameOver()
    {
        Debug.Log("Game Over Logic goes here");
    }
}

