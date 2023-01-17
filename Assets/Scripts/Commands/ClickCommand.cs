using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
    private GameObject _cube;
    private Color _currentColor, _previousColor;
    private MeshRenderer _cubeRenderer;

    public ClickCommand(GameObject cube, Color color, MeshRenderer renderer)
    {
        this._cube = cube;
        this._currentColor = color;
        this._cubeRenderer = renderer;
    }

    public void Execute()
    {
        Debug.Log("Performing Execute");
        //_previousColor = _cube.GetComponent<MeshRenderer>().material.color;
        _previousColor = _cubeRenderer.material.color;
        //_cube.GetComponent<MeshRenderer>().material.color = _currentColor;
        _cubeRenderer.material.color = _currentColor;
    }

    public void Undo()
    {
        Debug.Log("Performing Undo");
        //_cube.GetComponent<MeshRenderer>().material.color = _previousColor;
        _cubeRenderer.material.color = _previousColor;
    }
}
