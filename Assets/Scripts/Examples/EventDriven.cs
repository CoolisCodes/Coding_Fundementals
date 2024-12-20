using System;
using System.Collections.Generic;
using UnityEngine;

public class EventDriven : MonoBehaviour
{

    public Action<int, string> onGameStarted;
    // Start is called before the first frame update
    void Start()
    {
        onGameStarted += GameStarted;
        onGameStarted += LoadPlayer;


        onGameStarted?.Invoke(1, "ela");

    }


    public void GameStarted(int number, string test)
    {
        Debug.Log($"{test} {number}");
    }

    public void LoadPlayer(int number, string test) => Debug.Log($"{number} {test}");
}
