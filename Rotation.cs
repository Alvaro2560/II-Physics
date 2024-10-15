using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float velocidadRotacion = 100f;
    public float velocidadAvance = 5f;

    void Update()
    {
        transform.Rotate(0, 0, velocidadRotacion * Time.deltaTime);
        transform.Translate(transform.forward * velocidadAvance * Time.deltaTime);
        Debug.DrawRay(transform.position, transform.forward * 5f, Color.blue);
    }
}