using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float maxSpeed = 0.5f;//Replace with your max speed
    void FixedUpdate()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
        }
    }
}
