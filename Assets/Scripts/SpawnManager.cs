using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //singelton spawn manager
    private static SpawnManager _instance;

    [SerializeField] private GameObject _enemyPrefab;

    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The Spawn Manager is NULL.");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void SpawnEmeny()
    {
        Debug.Log("Spawning Enemies");
        if (_enemyPrefab == null)
        {
            _enemyPrefab = Resources.Load("LazyEnemy") as GameObject;
        }

        //Instantiate(_enemyPrefab, this.transform.position, Quaternion.identity);
    }
}
