using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public float throwForce = 10f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Throw()
    {
        rb.AddForce(transform.forward * throwForce, ForceMode.Force);
    }
}
