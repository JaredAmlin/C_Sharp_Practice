using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players
{
    public string playerName;
    public int playerID;

    public Players(string name, int id)
    {
        this.playerName = name;
        this.playerID = id;
    }
}

public class Game : MonoBehaviour
{
    Players player1 = new Players("John", 1);
    Players player2 = new Players("Rosemary", 2);
    Players player3 = new Players("Ellen", 3);
    Players player4 = new Players("Blair", 4);

    public Dictionary<int, Players> playerDictionary = new Dictionary<int, Players>();

    public Dictionary<string, int> people = new Dictionary<string, int>();

    public Dictionary<int, string> books = new Dictionary<int, string>();

    private void Start()
    {
        people.Add("Penelope", 37);
        people.Add("Frank", 23);
        people.Add("Charlotte", 17);

        books.Add(0, "The Origin Story");
        books.Add(1, "The Sequel");
        books.Add(2, "The Triad");

        int franksAge = people["Frank"];
        Debug.Log("Franks Age is " + franksAge);

        foreach (KeyValuePair<string, int> person in people)
        {
            Debug.Log(person.Key + " has entered the chat.");
        }

        foreach (KeyValuePair<int, string> book in books)
        {
            Debug.Log(book.Value + " is a NY Times Best Seller.");
        }

        playerDictionary.Add(player1.playerID, player1);
        playerDictionary.Add(player2.playerID, player2);
        playerDictionary.Add(player3.playerID, player3);
        playerDictionary.Add(player4.playerID, player4);

        Debug.Log($"the player {playerDictionary[1].playerName} has entered the game");

        foreach (Players players in playerDictionary.Values)
        {
            Debug.Log($"the player {players.playerName} has entered the game");
        }
    }
}
