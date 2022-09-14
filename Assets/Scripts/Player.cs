using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyCompany.MyLibrary.MyAsset;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    public WeaponStats(string name, float fireRate, int ammoCount)
    {
        //Initialization
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}

public class Player : MonoBehaviour, IDamagable, IHealable
{
    
    private WeaponStats _plasmaRifle;
    private WeaponStats _rocketLauncher;

    public string myName = "Jared";
    public int myAge = 40;
    private float _mySpeed = 10.5f;
    public int myHealth = 100;
    public int Score = 120;
    public bool hasKey = false;
    public int ammoCount = 10;

    public float Speed { get; private set; }

    public int Health { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        MyCompany.MyLibrary.MyAsset.Player asset = new MyCompany.MyLibrary.MyAsset.Player("Ronald", 57);

        _plasmaRifle = new WeaponStats("Plasma Rifle", 0.25f, 50);
        _rocketLauncher = new WeaponStats("Rocket Launcher", 3.5f, 5);

        Debug.Log($"The current weapon name is {_plasmaRifle.name}");

        Debug.Log("My Name is: " + myName + " and I am " + myAge + " years old.");
        Debug.Log("My Speed is: " + _mySpeed);
        Debug.Log("My health is: " + myHealth);
        Debug.Log("Do I have the keys?: " + hasKey);
        Debug.Log("How much ammo do I have?" + ammoCount);

        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();
        Player player4 = new Player();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.ChangeColor(this.gameObject, Color.green);
        }
    }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
    }

    public void Heal(int healAmount)
    {
        Health += healAmount;
    }
}
