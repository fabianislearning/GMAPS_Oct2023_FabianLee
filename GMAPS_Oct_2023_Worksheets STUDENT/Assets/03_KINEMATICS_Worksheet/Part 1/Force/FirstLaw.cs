using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FirstLaw : MonoBehaviour
{
    public Vector3 force;
    Rigidbody rb;
    
    void Start()
    {
        //Get the RigidBody component which is attached to the GameObject.
        rb = GetComponent<Rigidbody>();
        //The force variable will affect where the ball will be located at via the transform (position) property
        rb.transform.position = force;
    }

    void FixedUpdate()
    {
        Debug.Log(transform.position);
    }
}

