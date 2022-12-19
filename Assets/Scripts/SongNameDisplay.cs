using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongNameDisplay : MonoBehaviour
{
    public string[] songNames;

    public Text[] songText;

    public int[] songID;

    // Start is called before the first frame update
    void Start()
    {
        songText = new Text[songNames.Length];
        songID = new int[songNames.Length];

        //songText[0].text = songNames[0];

        AssignText();
    }

    private void AssignText()
    {
        foreach (int ID in songID)
        {
            songText[ID].text = songNames[ID];
        }
    }
}
