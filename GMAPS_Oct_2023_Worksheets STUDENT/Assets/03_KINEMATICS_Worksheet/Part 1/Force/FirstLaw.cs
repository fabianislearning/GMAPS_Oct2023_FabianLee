using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLaw : MonoBehaviour
{
    public Vector3 force;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward *10f *Time.deltaTime);
    }

    void FixedUpdate()
    {
       Debug.Log(transform.position);  
    }
}

