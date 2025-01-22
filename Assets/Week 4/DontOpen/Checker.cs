using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    private ButtonActions buttonActions;

    private void Start()
    {
        buttonActions = GetComponent<ButtonActions>();
    }

    private bool _has1, _has2, _has3, _has4;

    public void CheckAnswer(int num)
    {
        switch (num)
        {
            case 1:
                if (_has1) {break;}
                if (CheckAdd(buttonActions.task1))
                {
                    CorrectAnswer();
                    _has1 = true;
                }
                break;
            case 2:
                if (_has2) {break;}
                if (CheckSubtract(buttonActions.task2))
                {
                    CorrectAnswer();
                    _has2 = true;
                }
                break;
            case 3:
                if (_has3) {break;}
                if (CheckMultiply(buttonActions.task3))
                {
                    CorrectAnswer();
                    _has3 = true;
                }
                break;
            case 4:
                if (_has4) {break;}
                if (CheckToggle(buttonActions.isToggled))
                {
                    CorrectAnswer();
                    _has4 = true;
                }
                break;
            case 5:
                if (buttonActions.score == 0) {Reset();}
                break;
        }
    }

    public void Reset()
    {
        _has1 = false;
        _has2 = false;
        _has3 = false;
        _has4 = false;
    }

    private void CorrectAnswer()
    {
        Debug.Log("CORRECT ANSWER");
        buttonActions.score++;  // Increment the score
        buttonActions.ShowScore();  // Display updated score
    }

    private bool CheckAdd(int result)
    {
        return result == 8;  // Correct answer is 8 (5 + 3)
    }

    private bool CheckSubtract(int result)
    {
        return result == 3;  // Correct answer is 3 (8 - 5)
    }

    private bool CheckMultiply(int result)
    {
        return result == 24;  // Correct answer is 24 (4 * 6)
    }

    private bool CheckToggle(bool expectedState)
    {
        return expectedState == true;  // Initial correct state is true
    }
}
