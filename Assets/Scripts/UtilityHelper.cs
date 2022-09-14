using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    public static void ChangeColor(GameObject obj, Color col)
    {
        MeshRenderer _renderer = obj.GetComponent<MeshRenderer>();

        col = new Color(Random.value, Random.value, Random.value);

        _renderer.material.color = col;
    }
}
