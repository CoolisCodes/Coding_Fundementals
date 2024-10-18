using Unity.VisualScripting;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public Vector3 vector3 = Vector3.zero;

    public Quaternion quaternion = Quaternion.identity;

    public Vector3 vector3Scale = Vector3.zero;


    void Start()
    {
        Debug.Log("Ela kai pou eisai");

    }

    void Update()
    {
        transform.position = vector3;
        transform.rotation = quaternion;
        transform.localScale = vector3Scale;
    }
}
