using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
    public float TargetDistance;

    public PlayerController playerController;
    
    // Update is called once per frame
    void Update()
    {
        RaycastHit theHit;

        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out theHit))
        {
            TargetDistance = theHit.distance;

            if (theHit.transform.gameObject.CompareTag("Throwable"))
            {
                
                playerController.inputActions.InGame.Grab.performed += _ => playerController.GrabObj(theHit.transform.gameObject);

                if (playerController.inputActions.InGame.Grab.triggered)
                {
                    playerController.GrabObj(theHit.transform.gameObject);
                }

            }
           

        }
    }
}
