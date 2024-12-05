using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningState : StateBase
{
    public override void StartState()
    {
        stateManager.spawnedApple = GameObject.Instantiate(stateManager.applePrefab);

        stateManager.spawnedApple.transform.localScale = Vector3.zero;

        stateManager.ChangeState(stateManager.growingState);

    }

    public override void UpdateState()
    {
        //throw new System.NotImplementedException();
    }

    public SpawningState(StateManager stateManager) : base(stateManager)
    {
        Debug.Log("Spawining State initiallized");
    }
}
