using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force;
    public float jumpForce;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        force = 2;
        jumpForce = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Saltar();
        }
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }

    }

    private void Saltar()
    {
        if(rb)
            if (Math.Abs(rb.velocity.y) < 0.01f)    
            {
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            }
        
    }
}
