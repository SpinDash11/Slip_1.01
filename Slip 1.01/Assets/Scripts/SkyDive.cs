using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyDive : MonoBehaviour
{

    public Rigidbody rb;


    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        Dive();
    }

    private void Dive()
    {
        rb.drag = -40;
    }
}
