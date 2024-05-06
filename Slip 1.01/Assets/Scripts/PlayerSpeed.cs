using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpeed : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public TMP_Text speedText;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = playerRigidbody.velocity.magnitude;

        // converts the speed to a whole number
        int playerSpeed = (int)speed; 
        speedText.text = "speed: " + playerSpeed;
        
    }
}
