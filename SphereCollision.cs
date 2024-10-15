using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión con " + collision.gameObject.tag);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger con " + other.gameObject.tag);
    }
}