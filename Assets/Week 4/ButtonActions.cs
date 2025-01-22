using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    // DON'T TOUCH THIS CODE UNTIL YOU SEE THE FACE
    public int score, task1, task2, task3;
    void Start() { ShowScore(); }
    public void ShowScore() { Debug.Log("Score: " + score); }
    
    // YOU CAN TOUCH EVERYTHING BELOW THIS :)
    
    // Button 1: Addition
    public void AddNumbers()
    {
        // TODO: Add 5 and 3 together to form int "task1" , then log the result.
        // Hint: Use the below Debug.Log to display the result of 5 + 3
        
        Debug.Log(task1);
    }

    // Button 2: Subtraction
    public void SubtractNumbers()
    {
        // TODO: Subtract 5 from 8, then log the result.
        // Hint: Use the below Debug.Log to display the result of 8 - 5.
        
        Debug.Log(task2);
    }

    // Button 3: Multiply Numbers
    public void MultiplyNumbers()
    {
        // TODO: Multiply 4 and 6, then log the result.
        // Hint: Use Debug.Log to display the result of 4 * 6.
        
        Debug.Log(task3);
    }

    // Button 4: Toggle Bool Value
    public bool isToggled = false;

    public void ToggleBool()
    {
        // TODO: Toggle the bool value and log the new state.
        // Hint: Use below Debug.Log to display whether the bool is true or false.
        // Hint: The operator "!isToggled" flips the boolean value.
        
        Debug.Log(isToggled);
    }

    // Button 5: Reset Score
    public void ResetScore()
    {
        // TODO: Reset the score to 0 and log the updated score.
        // Hint: Use Debug.Log to display the reset score.
        
        Debug.Log(score);
    }
}