using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGravity : MonoBehaviour
{
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
     
        DelegateManager.onClick += Fall;
    }

    private void Fall()
    {
        if (_rb != null)
            _rb.useGravity = true;
    }

    private void OnDisable()
    {
        DelegateManager.onClick -= Fall;
    }
}
