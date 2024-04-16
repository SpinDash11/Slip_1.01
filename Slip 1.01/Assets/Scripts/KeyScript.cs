using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        keyText.text = "Keys Needed: " + keyCount + "/5";
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

            if (keyCount == 5)
            {
                SceneManager.LoadScene("Level 2");
            }

        }
    }
}
