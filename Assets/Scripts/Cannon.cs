using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform tip;
    // Start is called before the first frame update

    public float fireRate;

    void Start()
    {
        StartCoroutine(Fire());
    }

    private IEnumerator Fire()
    {
        while (true)
        {
            Debug.Log("Boom");
            Instantiate(bulletPrefab).transform.position = tip.transform.position;

            yield return new WaitForSeconds(fireRate);

        }
    }
}