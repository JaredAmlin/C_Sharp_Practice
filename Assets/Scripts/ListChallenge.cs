using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListChallenge : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private GameObject _sphere;
    [SerializeField] private GameObject _capsule;
    [SerializeField] private List<GameObject> _objectsToSpawn;
    [SerializeField] private List<GameObject> _obectsCreated;
    private bool _isDoneSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        //_objectsToSpawn = new List<GameObject> { GameObject.CreatePrimitive(PrimitiveType.Cube), GameObject.CreatePrimitive(PrimitiveType.Sphere), GameObject.CreatePrimitive(PrimitiveType.Capsule) };
        _objectsToSpawn = new List<GameObject> { _cube, _sphere, _capsule };
        _obectsCreated = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isDoneSpawning == false && _obectsCreated.Count < 10)
            {
                //instantiate random object from object list, add to objects created.Random spawn point between +- 10 on X/Y
                int randomObject = (Random.Range(0, _objectsToSpawn.Count));
                float randomX = Random.Range(-10f, 10f);
                float randomY = Random.Range(-10f, 10f);

                Vector3 randomSpawnPoint = new Vector3(randomX, randomY, 0);

                GameObject createdObject = Instantiate(_objectsToSpawn[randomObject], randomSpawnPoint, Quaternion.identity) as GameObject;

                _obectsCreated.Add(createdObject);
            }
            else
            {
                if (_isDoneSpawning == false)
                {
                    Debug.Log("The Object Count is full!!!");

                    _isDoneSpawning = true;

                    foreach (GameObject obj in _obectsCreated)
                    {
                        obj.GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    _obectsCreated.Clear();
                }
            }
        }
    }
}
