using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static int points;

    public static void AddPoints(int addedPoints)
    {
        points += addedPoints;
        Debug.Log("The current points are: " + points);
    }
}
