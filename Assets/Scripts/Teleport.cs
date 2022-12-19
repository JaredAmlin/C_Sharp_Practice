using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DelegateManager.onSpacePress += NewPosition;
    }

    private void NewPosition()
    {
        Vector3 _newPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
        transform.position = _newPosition;
    }

    private void OnDisable()
    {
        DelegateManager.onClick -= NewPosition;
    }
}
