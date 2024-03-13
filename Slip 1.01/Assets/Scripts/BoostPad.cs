using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoostPad : MonoBehaviour
{

    private int boostSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.IsDestroyed();
        }
    }
}
