using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    public PlayerControls playerControls;


    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();

        playerControls.GamePlay.Enable();

        playerControls.GamePlay.Jump.started += Jump;
    }


    void Update()
    {
    }

    public void Jump(InputAction.CallbackContext context) { Debug.Log("Jump"); }
}
