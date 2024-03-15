using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiatingPrefab : MonoBehaviour
{
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, new Vector3(0,0.46f,-0.3f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
