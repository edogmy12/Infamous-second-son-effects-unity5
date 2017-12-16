using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleThrusters : MonoBehaviour
{
    public Rigidbody rb;
    public Animator anim;

    public bool isGrounded = false;

    void Start()
    {
    }

    void Update()
    {
        if (anim.GetBool("Grounded") == false && Input.GetKey(KeyCode.Space))
        {
            isGrounded = false;
            rb.drag = 7;
        }
        else
        {
            rb.drag = 0;
        }
       
        if (anim.GetBool("Grounded") == true)
        {
            isGrounded = true;
            rb.drag = 0;

        }
    }
}
