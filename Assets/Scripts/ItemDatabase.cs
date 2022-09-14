using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public Item[] items = new Item[10];

    public List<GameObject> itemList = new List<GameObject>();

    private GameObject itemPrefab;

    public List<Item> itemsList = new List<Item>();

    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    [SerializeField] private List<string> _namesList = new List<string> 
    { "John", "Isabel", "Bernadette", "Frederick", "Jameson", "Angela" };

    public Item dagger;
    public Item sword;
    [SerializeField] private Item shield;

    public Weapon saber = new Weapon();
    public Potion health = new Potion();

    // Start is called before the first frame update
    void Start()
    {
        items[0] = new Item(); //populate arrray with Item

        itemList.Add(new GameObject()); //populate list with game object

        itemList.Add(itemPrefab); //add prefab gameobject to list

        items[0].itemName = "example item";

        itemList[0].name = "new list item";

        dagger = new Item(0, "lil stabber", "the sharpest of blades hides easily beneath a shrouded hand");

        sword = new Item();
        sword.itemID = 1;
        sword.itemName = "sword";
        sword.itemDescription = "This is an ancient short sword";

        shield = CreateItem(2, "basic shield", "this small shield is weathered and damaged");

        foreach (var item in items)
        {
            Debug.Log($"There is a {item.itemName} item in the invenroty system");
        }

        Debug.Log("INITIAL NAMES LIST");
        foreach (string name in _namesList)
        {
            Debug.Log(name);
        }

        itemsList[0].ItemAction();
        itemsList[1].ItemAction();
        itemsList[2].ItemAction();
        itemsList[3].ItemAction();

        itemsList.Add(new Item());

        itemDictionary.Add(0, new Item());

        Item butterKnife = new Item();
        butterKnife.itemName = "Butter Knife";
        butterKnife.itemID = 50;

        itemsList.Add(butterKnife);
        itemDictionary.Add(50, butterKnife);

        itemDictionary.Add(5, sword);
        itemDictionary.Add(12, dagger);
        itemDictionary.Add(3, shield);

        Debug.Log($"We added a {itemDictionary[50].itemName} to the item dictionary");

        foreach (KeyValuePair<int, Item> item in itemDictionary)
        {
            Debug.Log($"The Key for the {item.Value.itemName} item is {item.Key}");
        }

        foreach (int key in itemDictionary.Keys)
        {
            Debug.Log("Key:" + key);
        }

        foreach (Item item in itemDictionary.Values)
        {
            Debug.Log("Value:" + item.itemName);
        }

        //Item randomItem = itemDictionary[82];

        if (itemDictionary.ContainsKey(82))
        {
            Debug.Log("There is a key for this item!");
        }

        else
        {
            Debug.Log("There is no Key for this Item");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_namesList.Count > 1)
            {
                RemoveListName();
            }

            else if (_namesList.Count == 1)
            {
                _namesList.Clear();
            }

            else
            {
                Debug.Log("The Names List is EMPTY");

                return;
            }
        }
    }

    private void RemoveListName()
    {
        int randomName = Random.Range(0, _namesList.Count);

        Debug.Log("REMOVED NAME");

        Debug.Log($"The name {_namesList[randomName]} was removed");

        _namesList.Remove(_namesList[randomName]);

        Debug.Log("UPDATED NAMES LIST");

        foreach (string name in _namesList)
        {
            Debug.Log(name);
        }
    }

    private Item CreateItem(int itemID, string itemName, string itemDescription)
    {
        var item = new Item(itemID, itemName, itemDescription);

        return item;
    }
}
