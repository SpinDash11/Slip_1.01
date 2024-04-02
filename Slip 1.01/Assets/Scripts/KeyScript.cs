using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    public Text keyText;
    public int keyCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys: " + keyCount + "/5";
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
            ++keyCount;
        }

        if (collision.gameObject.tag == "Door")
        {
            //This will be for when the tower level is ready
            //Collision with Door will send player to new level when they have all 5 keys
        }

    }
}
