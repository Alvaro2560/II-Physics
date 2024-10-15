using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0, 0, 1);
    public float speed = 2f;
    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}