using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LightFlicker : MonoBehaviour
{


    Light testLight;
    public float minWaitTime;
    public float maxWaitTime;

    void Start()
    {
        testLight = GetComponent<Light>();
        //StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            testLight.enabled = !testLight.enabled;
            Debug.Log("Light flickered");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            StartCoroutine(Flashing());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            StopCoroutine(Flashing());
            testLight.enabled = true;
        }
    }
}
