using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    
    public float quizAverage;



    //create a program that calculates random quiz grades and prints the averages. 



    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0f, 100f);
        quiz2 = Random.Range(0f, 100f);
        quiz3 = Random.Range(0f, 100f);
        quiz4 = Random.Range(0f, 100f);
        quiz5 = Random.Range(0f, 100f);

        quizAverage = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        quizAverage = Mathf.Round(quizAverage * 100f) / 100f;

        Debug.Log("Quiz1: " + quiz1 + " Quiz2: " + quiz2 + " Quiz3: " + quiz3 + " Quiz4: " + quiz4 + " Quiz5: " + quiz5 + " are the test results. Your class average is " + quizAverage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
