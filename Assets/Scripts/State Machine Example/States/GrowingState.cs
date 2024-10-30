using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingState : StateBase
{

    private GameObject apple;
    public Vector3 targetScale = new Vector3(0.15f, 0.15f, 0.15f); // The scale we want to reach
    public float scaleSpeed = 1.0f; // The speed of scaling

    public GrowingState(StateManager stateManager) : base(stateManager)
    {
        Debug.Log("GRowing State initiallized");
    }

    public override void StartState()
    {
        apple = stateManager.spawnedApple;
    }

    public override void UpdateState()
    {
        apple.transform.localScale = Vector3.Lerp(apple.transform.localScale, targetScale, scaleSpeed * Time.deltaTime);

        // Optional: Stop scaling once close enough to the target scale
        if (Vector3.Distance(apple.transform.localScale, targetScale) < 0.01f)
        {
            apple.transform.localScale = targetScale; // Snap to target scale
            //enabled = false; // Disable this script

            stateManager.ChangeState(stateManager.fallingState);
        }
    }
}
