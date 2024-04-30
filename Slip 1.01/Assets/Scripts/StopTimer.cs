using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimer : MonoBehaviour
{
   
    // access the timer script
    public Timer timerScript; 

    private void OnTriggerEnter(Collider other)
    {
        if (timerScript != null)
        {
            timerScript.timerisRunning = false;
            
        }
    }
}
