using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameOnSpace : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Toggle pause
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;    // Freeze game
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;    // Resume game
        isPaused = false;
    }
}
