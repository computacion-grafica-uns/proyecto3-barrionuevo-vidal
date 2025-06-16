using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAspas : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Rotate(Vector3.left * speed * Time.deltaTime);
    }
}
