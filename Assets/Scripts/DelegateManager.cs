using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    //public delegate void ChangeColor(Color newColor);
    //public ChangeColor onColorChange;

    public static Action<Color> onColorChange;

    //public delegate void OnComplete();
    //public OnComplete onComplete;

    public static Action onComplete;

    //public delegate void OnClick();
    //public static event OnClick onClick;

    public static Action onClick;

    //public delegate void OnSpacePress();
    //public static event OnSpacePress onSpacePress;

    public static Action onSpacePress;

    //pass in a string and return the length
    //private delegate int StringLength(string text);
    //private StringLength _stringLength;

    private Func<string, int> onStringLength;

    private Action<int, int> Sum;

    private Action onGetObjectName;

    private Func<int> onNameLength;

    private Func<int, int, int> onReturnSum;

    private WaitForSeconds _completedWaitTime = new WaitForSeconds(5f);



    private void Start()
    {
        onColorChange = UpdateColor;
        if (onColorChange != null)
            onColorChange(Color.blue);

        onComplete = TaskCompleted;
        if (onComplete != null)
            onComplete();

        onComplete += TaskCompleted;
        onComplete += TaskCompleted2;
        onComplete += TaskCompleted3;
        if (onComplete != null)
            onComplete();

        onComplete -= TaskCompleted;
        onComplete -= TaskCompleted3;
        onComplete -= TaskCompleted2;
        if (onComplete != null)
            onComplete();

        //_stringLength = GetStringLength;
        //Debug.Log(_stringLength("Jared"));

        //StringLength = GetStringLength;
        onStringLength = (text) => text.Length;
        Debug.Log("The string count is " + onStringLength("Jared"));

        //Sum = CalculateSum;
        Sum = (a, b) => { var SumTotal = a + b; Debug.Log("The Calculated Sum is " + SumTotal); };
        if (Sum != null)
            Sum(7, 7);

        onGetObjectName = () => Debug.Log("This object name is " + this.gameObject.name);
        if (onGetObjectName != null)
            onGetObjectName();

        //onNameLength = ReturnObjectNameLength;
        //if (onNameLength != null)
        //onNameLength();
        onNameLength = () => this.gameObject.name.Length;
        if (onNameLength != null)
        {
            int characterCount = onNameLength();
            Debug.Log("The character count of this object is " + characterCount);
        }

        //onReturnSum = ReturnSumValue;
        //onReturnSum = (a, b) => a + b;
        //Debug.Log("The total sum is " + onReturnSum(10, 3));
        onReturnSum = (a, b) => { var totalSum = a + b; Debug.Log("The total sum is " + totalSum); return totalSum; };
        if (onReturnSum != null)
            onReturnSum(12, 10);

        StartCoroutine(CompletedRoutine(() => 
        {
            Debug.Log("The routine has finished");
            Debug.Log("Run some code here!");
        }));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            OnSpacePressEvent();
    }

    public void UpdateColor(Color newColor)
    {
        Debug.Log("Updating color to " + newColor.ToString());
    }

    public void TaskCompleted()
    {
        Debug.Log("Task 1 has been completed");
    }

    public void TaskCompleted2()
    {
        Debug.Log("Task 2 has been completed");
    }

    public void TaskCompleted3()
    {
        Debug.Log("Task 3 has been completed");
    }

    public void OnClickEvent()
    {
        if (onClick != null)
            onClick();
    }

    public void OnSpacePressEvent()
    {
        if (onSpacePress != null)
            onSpacePress();
    }

    //private int GetStringLength(string text)
    //{
        //return text.Length;
    //}

    //private void CalculateSum(int a, int b)
    //{
    //    var SumTotal = a + b;
    //    Debug.Log("The Calculated Sum is " + SumTotal);
    //}

    //private void GetName()
    //{
    //    Debug.Log("This object name is " + this.gameObject.name);
    //}

    //private int ReturnObjectNameLength()
    //{
    //    var count = this.gameObject.name.Length;
    //    Debug.Log("character count is " + count);
    //    return count;
    //}

    //private int ReturnSumValue(int a, int b)
    //{
    //    var total = a + b;
    //    Debug.Log("The total Sum is " + total);
    //    return a + b;
    //}

    private IEnumerator CompletedRoutine(Action onCompleteRoutine = null)
    {
        yield return _completedWaitTime;

        if (onCompleteRoutine != null)
            onCompleteRoutine();
    }
}
