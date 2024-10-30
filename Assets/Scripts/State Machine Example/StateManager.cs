using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public StateBase currentState;

    public SpawningState spawningState;
    public GrowingState growingState;
    public FallingState fallingState;

    public GameObject applePrefab;

    public GameObject spawnedApple;

    void Start()
    {
        spawningState = new SpawningState(this);
        growingState = new GrowingState(this);
        fallingState = new FallingState(this);

        ChangeState(spawningState);
    }


    public void ChangeState(StateBase stateBase)
    {
        currentState = stateBase;

        currentState.StartState();
    }

    void Update()
    {
        currentState.UpdateState();

        if (Input.GetKeyDown(KeyCode.Escape)) { Debug.Log("Escape pressed"); }
    }
}
