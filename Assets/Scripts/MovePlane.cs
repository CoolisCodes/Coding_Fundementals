using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovePlane : MonoBehaviour
{
    public float force = 10f;
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input for horizontal and vertical movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement force direction
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Apply force to the Rigidbody
        rb.AddForce(movement * force);
    }
}