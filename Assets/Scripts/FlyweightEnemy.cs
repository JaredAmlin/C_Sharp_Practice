using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightEnemy : MonoBehaviour
{
    private static int _maxHealth = 100;
    private static int _minHealth = 0;
    [SerializeField] private int _currentHealth;

    private static float _speed = 3.5f;

    [SerializeField] private Transform _player;

    private static WaitForSeconds _fireRate = new WaitForSeconds(2f);

    private const string _playerTag = "Player";
    private const string _fireRoutine = "FireRoutine";

    private void Start()
    {
        _currentHealth = _maxHealth;

        StartCoroutine(_fireRoutine);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, _player.position, _speed * Time.deltaTime);
    }

    private void Damage(int damageAmount)
    {
        _currentHealth -= damageAmount;

        if (_currentHealth <= _minHealth)
        {
            Destroy(this.gameObject);
        }
    }

    private IEnumerator FireRoutine()
    {
        while (true)
        {
            //fire projectile
            yield return _fireRate;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_playerTag))
        {
            Damage(_maxHealth);
        }
    }
}
