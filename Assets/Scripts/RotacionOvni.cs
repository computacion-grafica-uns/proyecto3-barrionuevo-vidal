using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionOvni : MonoBehaviour
{
     public float velocidadRotacion = 30f; // grados por segundo

    void Update()
    {
        transform.Rotate(0f, velocidadRotacion * Time.deltaTime, 0f);
    }
}
