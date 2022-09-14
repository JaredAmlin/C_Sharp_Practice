using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyCompany.MyLibrary.MyAsset
{
    public class Player : MonoBehaviour
    {
        public string playerName;
        public int playerID;

        public Player(string name, int id)
        {
            this.playerName = name;
            this.playerID = id;
        }
    }
}
