using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSphereMovement : MonoBehaviour
{
    public Transform esfera;
    public float velocidad = 2f;

    void Start()
    {
        esfera = GameObject.Find("Sphere").transform;
    }
    
    void Update()
    {
        Vector3 direction = esfera.position - transform.position;
        direction.y = 0;
        direction = direction.normalized;
        transform.Translate(direction * velocidad * Time.deltaTime, Space.World);
        transform.LookAt(esfera);
    }
}