using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 20.0f;
    public float boostSpeed;
    public float dragSpeed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BoostPad")
        {
            boostSpeed = speed;
            speed = boostSpeed * 2;
        }

        else
        {
            

            speed = 25;
        }

        if(collision.gameObject.tag == "DragPad")
        {
            dragSpeed = speed;
            speed = dragSpeed / 2;
        }
    }
}
