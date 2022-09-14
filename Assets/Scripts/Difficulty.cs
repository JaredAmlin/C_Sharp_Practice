using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Difficulty : MonoBehaviour
{
    private enum DifficultySelector
    {
        Easy, Normal, Hard, Expert
    }

    [SerializeField] private DifficultySelector _currentDifficulty;

    private enum WeaponPower
    {
        Weak = 2, Medium = 5, Strong = 8, OP = 12
    }

    [SerializeField] private WeaponPower _weaponPower;

    private void Start()
    {
        switch(_currentDifficulty)
        {
            case DifficultySelector.Easy:
                Debug.Log("The difficulty is Easy");
                break;
            case DifficultySelector.Normal:
                Debug.Log("The difficulty is Normal");
                break;
            case DifficultySelector.Hard:
                Debug.Log("The difficulty is Hard");
                break;
            case DifficultySelector.Expert:
                Debug.Log("The difficulty is Expert");
                break;
            default: Debug.Log("Difficulty outside of range");
                break;
        }

        //SceneManager.LoadScene((int)_currentDifficulty);
    }
}
