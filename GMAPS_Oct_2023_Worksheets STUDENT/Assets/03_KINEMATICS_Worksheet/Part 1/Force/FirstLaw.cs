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
        /* There are different force modes when it comes to adding a force, 
        the Impulse mode involves taking the Rigidbody's mass andd applying a sudden burst of force to the object */
        rb.AddForce(force, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        Debug.Log(transform.position);
    }
}

