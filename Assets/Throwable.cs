using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Throwable : MonoBehaviour
{
    public float throwForce = 10f;
    public Rigidbody rb;

    public float alertRadius = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Throw()
    {
        rb.AddForce(transform.forward * throwForce, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, alertRadius);
        foreach(var hitCollider in hitColliders)
        {
            if(hitCollider.gameObject.tag == "Enemy")
            {
                hitCollider.gameObject.GetComponent<NavMeshAgent>().SetDestination(transform.position);
            }
        }
    }

    /*public void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(transform.position, alertRadius);
    }
    */

}
