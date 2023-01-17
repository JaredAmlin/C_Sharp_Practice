using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingelton<T> : MonoBehaviour where T : MonoSingelton<T>
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The " + typeof(T).ToString() + " is NULL");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this as T;

        Initialization();
    }

    public virtual void Initialization()
    {
        //optional to override this
    }
}
