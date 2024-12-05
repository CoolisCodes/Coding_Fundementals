using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerables : MonoBehaviour
{
    int[] ints = { 0, 1, 2, 3, 4, 5 };

    void Start()
    {
        foreach (int num in ints) { Debug.Log(num); }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
