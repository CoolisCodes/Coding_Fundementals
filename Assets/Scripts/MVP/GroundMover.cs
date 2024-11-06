using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{
    private Material rend;
    public bool start = false;
    public float speed = 0.5f;

    void Start()
    {
        rend = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        float offsetY = Time.time * -speed;
        rend.mainTextureOffset = new Vector2(0, offsetY);
    }

}
