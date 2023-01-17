using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private const string _hideProjectile = "HideProjectile";

    [SerializeField] private int _timeToHide = 5;

    private void OnEnable()
    {
        Invoke(_hideProjectile, _timeToHide);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);
    }

    private void HideProjectile()
    {
        this.gameObject.SetActive(false);
    }
}
