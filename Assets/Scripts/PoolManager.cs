using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoSingelton<PoolManager>
{
    //make singleton
    //generate list of bullets
    [SerializeField] private GameObject _projectile;

    private const string _projectileName = "Projectile";

    [SerializeField] private List<GameObject> _projectilePool;

    [SerializeField] private int _maxProjectiles = 10;

    [SerializeField] private GameObject _projectileContainer;

    private void Start()
    {
        NullChecks();

        _projectilePool = CreateProjectiles(_maxProjectiles);
    }

    private void NullChecks()
    {
        if (_projectile == null)
            _projectile = Resources.Load(_projectileName) as GameObject;
    }

    public List<GameObject> CreateProjectiles(int maxProjectiles)
    {
        for (int i = 0; i < maxProjectiles; i++)
        {
            GameObject projectile = Instantiate(_projectile);
            projectile.transform.parent = _projectileContainer.transform;
            projectile.SetActive(false);

            _projectilePool.Add(projectile);
        }
        
        return _projectilePool;
    }

    public GameObject RequestProjectile()
    {
        //loop through projectile list
        foreach (GameObject projectile in _projectilePool)
        {
            if (projectile.activeInHierarchy == false)
            {
                //projectile is available
                projectile.SetActive(true);
                return projectile;
            }
        }

        GameObject additionalProjectile = Instantiate(_projectile);
        additionalProjectile.transform.parent = _projectileContainer.transform;
        _projectilePool.Add(additionalProjectile);
        return additionalProjectile;
    }
}
