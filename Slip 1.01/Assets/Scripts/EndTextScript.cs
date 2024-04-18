using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTextScript : MonoBehaviour
{
    public Text endText;

    // Start is called before the first frame update
    void Start()
    {
        endText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            endText.enabled = true;
        }
    }
}
