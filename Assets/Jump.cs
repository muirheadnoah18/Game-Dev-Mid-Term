using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Jump : MonoBehaviour
{

    public float jumpForce;
    public Rigidbody reggiebody;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 forceVector = Vector3.up * jumpForce;
            reggiebody.AddForce(forceVector);
        }
    }
}
