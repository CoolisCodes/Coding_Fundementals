using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingState : StateBase
{
    public FallingState(StateManager stateManager) : base(stateManager)
    {
        Debug.Log("Spawining Falling initiallized");
    }

    public override void StartState()
    {
        stateManager.spawnedApple.AddComponent<Rigidbody>();
    }

    public override void UpdateState()
    {
    }

}
