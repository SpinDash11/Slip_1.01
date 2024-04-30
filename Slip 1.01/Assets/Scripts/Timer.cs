using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerText;
    public float currentTime;

    public bool timerisRunning = true;
     
    

    // Update is called once per frame
    void Update()
    {
        if (timerisRunning)
        {
            currentTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);
            TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        }
    }

   

    
}
