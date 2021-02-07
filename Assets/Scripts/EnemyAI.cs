using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;
    Vector3 lastSeenPos;

    public float sightRadius;
    public float sightAngle;

    bool hasSeenPlayer = false;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        hasSeenPlayer = SeenPlayer(transform, player.transform, sightAngle, sightRadius);
    }

    public static bool SeenPlayer(Transform checkingObj, Transform target, float maxAngle, float maxRadius)
    {
        Collider[] overlaps = new Collider[10];
        int count = Physics.OverlapSphereNonAlloc(checkingObj.position, maxRadius, overlaps);

        for(int i = 0; i < count + 1; i++)
        {
            if(overlaps[i].transform == target)
            {
                Vector3 directionBetween = (target.position - checkingObj.position).normalized;
                directionBetween.y *= 0;

                float angle = Vector3.Angle(checkingObj.forward, directionBetween);

                if(angle <= maxAngle)
                {
                    Ray ray = new Ray(checkingObj.position, target.position - checkingObj.position);
                    RaycastHit hit;

                    if(Physics.Raycast(ray, out hit, maxRadius))
                    {
                        if(hit.transform == target)
                        {
                            return true;
                        }
                    }
                }
            }
        }

        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRadius);
        //FOV Line creation
        Vector3 fovLine1 = Quaternion.AngleAxis(sightAngle, transform.up) * transform.forward * sightRadius;
        Vector3 fovLine2 = Quaternion.AngleAxis(-sightAngle, transform.up) * transform.forward * sightRadius;

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, fovLine1);
        Gizmos.DrawRay(transform.position, fovLine2);
        //Player tracking visualised
        if(!hasSeenPlayer)
            Gizmos.color = Color.red;
        else
            Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, (player.transform.position-transform.position).normalized * sightRadius);
        //Forward facing
        Gizmos.color = Color.black;
        Gizmos.DrawRay(transform.position, transform.forward * sightRadius);
    }
}
