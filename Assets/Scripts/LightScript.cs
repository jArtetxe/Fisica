using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            gameObject.GetComponent<Light>().enabled = true;
        }
        if(Input.GetKeyUp(KeyCode.I))
        {
            gameObject.GetComponent<Light>().enabled = false;
        }
    }
}
