using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Comet : MonoBehaviour
{
    public Vector3 movementDirection = Vector3.forward; // Default to move along the Z-axis
    public float speed = 5f; // Speed of the object

    private Rigidbody rb;

    void Start()
    {
        speed = GameManager.instance.currentEnemySpeed;
        // Get the Rigidbody component attached to the object
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Apply a constant velocity to the object in the specified direction
        rb.velocity = movementDirection.normalized * speed;
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "SpaceShip") GameManager.instance.spaceship.Crashed();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "End") Destroy(gameObject);
    }
}
