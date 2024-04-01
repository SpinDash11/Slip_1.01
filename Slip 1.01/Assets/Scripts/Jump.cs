using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public float dive;
    private bool isJumping;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping) 
        {
            rb.AddForce(Vector3.up * 200);
            isJumping = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(-Vector3.up * dive);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            isJumping = false;
        }
    }
}
