using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Respawning : MonoBehaviour
{
    public GameObject Respawn;
    public GameObject CheckPoint;

    public bool checkPointisActive = false;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPoint")
        {
            checkPointisActive = true;
        }

        if (other.gameObject.tag == "DeathZone")
        {
            if (checkPointisActive == true)
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
