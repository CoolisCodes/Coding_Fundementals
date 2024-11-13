using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameState currentState;

    private void Start()
    {
        // Start the game in the MainMenu state
        SetState(GameState.MainMenu);
    }

    private void Update()
    {
        // Handle state transitions based on input or events
        switch (currentState)
        {
            case GameState.MainMenu:
                if (Input.GetKeyDown(KeyCode.Return)) // Press Enter to start
                {
                    SetState(GameState.Playing);
                }
                break;

            case GameState.Playing:
                if (Input.GetKeyDown(KeyCode.Escape)) // Press Escape to pause
                {
                    SetState(GameState.Paused);
                }
                break;

            case GameState.Paused:
                if (Input.GetKeyDown(KeyCode.Escape)) // Press Escape again to unpause
                {
                    SetState(GameState.Playing);
                }
                break;

            case GameState.GameOver:
                if (Input.GetKeyDown(KeyCode.Return)) // Press Enter to return to Main Menu
                {
                    SetState(GameState.MainMenu);
                }
                break;
        }
    }

    public void SetState(GameState newState)
    {
        // Handle exiting the current state
        switch (currentState)
        {
            case GameState.Playing:
                OnExitPlaying();
                break;
            case GameState.Paused:
                OnExitPaused();
                break;
            case GameState.GameOver:
                OnExitGameOver();
                break;
        }

        // Update the current state and enter the new state
        currentState = newState;

        switch (newState)
        {
            case GameState.MainMenu:
                OnEnterMainMenu();
                break;
            case GameState.Playing:
                OnEnterPlaying();
                break;
            case GameState.Paused:
                OnEnterPaused();
                break;
            case GameState.GameOver:
                OnEnterGameOver();
                break;
        }
    }

    private void OnEnterMainMenu()
    {
        Debug.Log("Entered Main Menu State");
        // Show Main Menu UI, etc.
    }

    private void OnEnterPlaying()
    {
        Debug.Log("Entered Playing State");
        // Start spawning enemies, reset player position, etc.
    }

    private void OnEnterPaused()
    {
        Debug.Log("Entered Paused State");
        Time.timeScale = 0f; // Freeze game time
    }

    private void OnEnterGameOver()
    {
        Debug.Log("Entered Game Over State");
        Time.timeScale = 0f; // Freeze game time (optional)
    }

    private void OnExitPlaying()
    {
        Debug.Log("Exiting Playing State");
    }

    private void OnExitPaused()
    {
        Debug.Log("Exiting Paused State");
        Time.timeScale = 1f; // Resume game time
    }

    private void OnExitGameOver()
    {
        Debug.Log("Exiting Game Over State");
        Time.timeScale = 1f; // Resume game time
    }
}
