using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class StateBase
{
    public StateManager stateManager;

    public abstract void StartState();
    public abstract void UpdateState();

    public StateBase(StateManager stateManager)
    {
        this.stateManager = stateManager;
    }
}
