using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0, 0, 0);
    public float speed = 2f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            moveDirection = new Vector3(0, 1, 0);
        } else if (Input.GetKey(KeyCode.S)) {
            moveDirection = new Vector3(0, -1, 0);
        } else if (Input.GetKey(KeyCode.A)) {
            moveDirection = new Vector3(-1, 0, 0);
        } else if (Input.GetKey(KeyCode.D)) {
            moveDirection = new Vector3(1, 0, 0);
        }
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}