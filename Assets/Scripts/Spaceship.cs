using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public GameObject bulletPrefab;      // Bullet prefab
    public Transform bulletSpawnPoint;   // Where the bullets will spawn from
    public float bulletSpeed = 20f;      // Bullet speed
    public float fireRate = 0.1f;       // Rate of fire (time between shots)

    private float fireCooldown = 0f;     // To track time for firing bullets

    void Update()
    {
        // Handle continuous shooting
        fireCooldown -= Time.deltaTime;

        if (fireCooldown <= 0f)
        {
            Shoot();
            fireCooldown = fireRate;
        }
    }

    void Shoot()
    {
        // Instantiate bullet and apply velocity
        GameObject bullet = ObjectPool.Instance.GetBullet();
        if (bullet != null)
        {
            bullet.transform.position = bulletSpawnPoint.position;  // Position it at the spawn point
            bullet.transform.rotation = bulletSpawnPoint.rotation;  // Align rotation
            bullet.SetActive(true);  // Activate bullet
        }
    }
}
