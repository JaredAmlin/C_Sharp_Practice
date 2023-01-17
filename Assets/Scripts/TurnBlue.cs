using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBlue : MonoBehaviour
{
    private MeshRenderer _renderer;

    private void OnEnable()
    {
        _renderer = GetComponent<MeshRenderer>();
        //subscribe to turn blue event
        MyCompany.MyLibrary.MyAsset.Player.onColorBlue += Player_onColorBlue;
    }

    private void Player_onColorBlue()
    {
        //change color to blue
        Color _randomColor = new Color(Random.value, Random.value, Random.value);
        _renderer.material.color = _randomColor;
    }

    private void OnDisable()
    {
        //unsubscribe to turn blue event
        MyCompany.MyLibrary.MyAsset.Player.onColorBlue -= Player_onColorBlue;
    }
}
