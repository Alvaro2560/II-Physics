using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeVelocity : MonoBehaviour
{
    public float velocidad = 5f;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha Arriba: " + (velocidad * vertical));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha Abajo: " + (velocidad * vertical));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha Izquierda: " + (velocidad * horizontal));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha Derecha: " + (velocidad * horizontal));
        }
    }
}