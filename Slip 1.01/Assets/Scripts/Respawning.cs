using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Respawning : MonoBehaviour
{
    public GameObject Respawn;

    // sets the new respawn checkpoint
    public GameObject CheckPoint;

    // OnTrigger Checks to see if the checkpoint is set to true(active)
    public bool isActive = false;


    // changed OnCollision to Ontrigger:
    private void OnTriggerEnter(Collider other)
    {
         // activates the checkpoint when the player collides with the checkpoint. 
        if (other.gameObject.tag == "CheckPoint")
        {
            isActive = true;
        }

        if (other.gameObject.tag == "DeathZone")
        {
            if (isActive == true)
            {
                this.transform.position = CheckPoint.transform.position;
            }
            else
            {
                this.transform.position = Respawn.transform.position;
            }
            

        } 
    }
  

}
