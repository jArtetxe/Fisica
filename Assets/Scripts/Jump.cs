using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    public float jumpForce;
    public float speed;
    public bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jumping();
    }

    private void Jumping()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(transform.up * jumpForce);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            canJump = true;
        }
    }
}
