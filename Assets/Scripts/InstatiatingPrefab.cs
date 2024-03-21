using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiatingPrefab : MonoBehaviour
{
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, new Vector3(-0.01f,-0.6589643f,21.68f), Quaternion.Euler(0,90,0));
        Instantiate(prefab, new Vector3(-17.22f,-0.6589643f,-3.32f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
