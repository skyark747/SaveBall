using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 10f;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward*force);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Vector3.forward*force);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right*force);
        }
        else if( Input.GetKey(KeyCode.A)) 
        {

            rb.AddForce(-Vector3.right * force);
        }
        
    }
}
