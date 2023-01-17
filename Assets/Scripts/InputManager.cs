using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoSingelton<InputManager>
{
    public void GetInput()
    {
        Debug.Log("The Input Manager is working.");
    }

    public override void Initialization()
    {
        base.Initialization();

        Debug.Log("Input manager initialized");
    }
}
