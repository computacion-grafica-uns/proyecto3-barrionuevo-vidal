using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoOvni : MonoBehaviour
{
     public float amplitud = 1f;         // Qué tan alto sube y baja
    public float frecuencia = 1f;       // Qué tan rápido se mueve

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        float nuevaY = posicionInicial.y + Mathf.Sin(Time.time * frecuencia) * amplitud;
        transform.position = new Vector3(posicionInicial.x, nuevaY, posicionInicial.z);
    }
}
