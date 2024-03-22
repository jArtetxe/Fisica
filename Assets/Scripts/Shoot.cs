using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;

    public float shootForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            GameObject bullet1 = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f), Quaternion.identity);
            bullet1.GetComponent<Rigidbody>().AddForce(shootForce * Vector3.forward);
        }
    }
}
