using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Throwable : MonoBehaviour
{
    public float throwForce = 10f;
    public Rigidbody rb;
    public GameObject brokenObject;
    public bool wasThrown;
    public bool canBreak;

    public float stunTime = 3f;

    public float alertRadius = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Throw()
    {
        rb.AddForce(transform.forward * throwForce, ForceMode.Force);

        wasThrown = true;
    
    }

    void OnCollisionEnter(Collision other)
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, alertRadius);
        foreach(var hitCollider in hitColliders)
        {
            if(hitCollider.gameObject.tag == "Enemy")
            {
                hitCollider.gameObject.GetComponent<NavMeshAgent>().SetDestination(transform.position);
            }
        }

        if (other.gameObject.tag == "Enemy")
        {
            EnemyAI ai = other.gameObject.GetComponent<EnemyAI>();
            if (ai != null)
                StartCoroutine(ai.StunAI(stunTime));
        }

        if (wasThrown && canBreak)
        {
            GameObject instObj = brokenObject;
            Instantiate(instObj, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }


    /*public void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(transform.position, alertRadius);
    }
    */

}

