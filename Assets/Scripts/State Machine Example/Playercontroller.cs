using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameStateManager gameStateManager;

    private void Start()
    {
        gameStateManager = FindObjectOfType<GameStateManager>();
    }

    void Update()
    {
        if (gameStateManager.currentState != GameState.Playing) return;

        // Process player input for movement and shooting
    }
}


