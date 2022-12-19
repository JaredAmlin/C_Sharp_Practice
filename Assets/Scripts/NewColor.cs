using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewColor : MonoBehaviour
{
    private MeshRenderer _renderer;
    private Color _randomColor;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();

        DelegateManager.onClick += UpdateColor;
    }

    private void UpdateColor()
    {
        _randomColor = new Color(Random.value, Random.value, Random.value);
        if (_renderer != null)
            _renderer.material.color = _randomColor;
    }

    private void OnDisable()
    {
        DelegateManager.onClick -= UpdateColor;
    }
}
