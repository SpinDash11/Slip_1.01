using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 20.0f;
    public float boostSpeed;
    public float dragSpeed;

    public Transform orientation;

    float moveHorizontal;
    float moveVertical;

    Vector3 moveDirection;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        GearShiftFast();
        GearShiftSlow();
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        moveDirection = orientation.forward * moveVertical + orientation.right * moveHorizontal;
        rb.AddForce(moveDirection.normalized * speed, ForceMode.Force);
    }

    private void GearShiftFast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed = 50;
        }
    }

    private void GearShiftSlow()
    {
        if (Input.GetMouseButtonDown(1))
        {
            speed = 5;
        }
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
        }

        if (collision.gameObject.tag == "DeathZone")
        {
            speed = 0;
        }
    }
}
