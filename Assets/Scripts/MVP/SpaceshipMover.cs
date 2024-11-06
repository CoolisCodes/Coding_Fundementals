using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMover : MonoBehaviour
{
    public float speed = 10f; // Speed of the spaceship

    void Update()
    {
        // Get horizontal input (-1 for left, 1 for right, 0 if no input)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the new position based on input and speed
        Vector3 movement = new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        // Move the spaceship to the new position
        transform.Translate(movement);


    }
    public void Tarxidiamou() { }

}
