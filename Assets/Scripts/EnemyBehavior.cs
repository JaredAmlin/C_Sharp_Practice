using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private int _health = 100;

    private enum EnemyState
    {
        Patrol, Follow, Attack, Defend, Evade, Death
    }

    [SerializeField] private EnemyState _currentState;

    // Update is called once per frame
    void Update()
    {
        //ChangeEnemyState();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeEnemyState();
        }
    }

    private void ChangeEnemyState()
    {
        _currentState++;

        if (_currentState > EnemyState.Death)
        {
            _currentState = EnemyState.Patrol;
        }

        switch (_currentState)
        {
            case EnemyState.Patrol:
                //run patrol code here
                Debug.Log("Enemy is Patroling");
                break;
            case EnemyState.Follow:
                //run follow code here
                Debug.Log("Enemy is Following");
                break;
            case EnemyState.Attack:
                //run attack code here
                Debug.Log("Enemy is Attacking");
                break;
            case EnemyState.Defend:
                //run defend code here
                Debug.Log("Enemy is Defending");
                break;
            case EnemyState.Evade:
                //run evede code here
                if (_health < 20)
                {
                    //run evade movement here
                }
                Debug.Log("Enemy is Evading");
                break;
            case EnemyState.Death:
                //run death code here
                Debug.Log("Enemy is Dead");
                break;
            default: Debug.Log("Unknown enemy state!");
                break;
        }    
    }
}
