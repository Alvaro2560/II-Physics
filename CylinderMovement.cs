using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    public Transform esfera;
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 2f;
    public float fuerzaMovimiento = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            rb.AddForce(Vector3.forward * fuerzaMovimiento);
        } 
        else if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(Vector3.back * fuerzaMovimiento);
        } 
        else if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(Vector3.left * fuerzaMovimiento);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rb.AddForce(Vector3.right * fuerzaMovimiento);
        }
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical).normalized;
        rb.AddForce(movimiento * fuerzaMovimiento);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, velocidadMovimiento);
        Vector3 direccionHaciaEsfera = esfera.position - transform.position;
        direccionHaciaEsfera.y = 0;
        if (direccionHaciaEsfera != Vector3.zero)
        {
            Quaternion rotacionObjetivo = Quaternion.LookRotation(direccionHaciaEsfera);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, Time.deltaTime * velocidadRotacion);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direccionHaciaEsferaNormalized = (esfera.position - transform.position).normalized;
            rb.AddForce(direccionHaciaEsferaNormalized * fuerzaMovimiento);
        }
    }
}
