using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifespan = 5f;  // Time before the bullet is destroyed

    private float timeAlive = 0f;

    void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Destroy the bullet after the lifespan expires
        timeAlive += Time.deltaTime;
        if (timeAlive > lifespan)
        {
            Destroy(gameObject); // Deactivate bullet (use object pooling)
        }
    }

    // Detect collision with comet
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Comet"))
        {
            // Destroy comet and bullet
            Destroy(collision.gameObject);
            gameObject.SetActive(false); // Deactivate bullet
        }
    }
}

