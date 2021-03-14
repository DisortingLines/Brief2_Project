using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour
{
    #region variables
    [Header("Components")]
    public InputActions inputActions;
    public Rigidbody rb;
    public CapsuleCollider col;
    public Camera cam;

    [Space]
    [Header("Variables")]
    public float moveSpeed = 3f;
    public float runSpeed = 5f;
    public float defaultSpeed = 3f;
    public float crouchSpeed = 0.5f;
    public float crouchRunSpeed = 3.5f;
    public float defaultRunSpeed = 5f;

    [SerializeField]
    private bool isCrouching = false;

    public float jumpVelocity = 5f;
    public LayerMask groundLayers;
    public float TargetDistance;
    public float grabRange = 3f;
    public GameObject grabbedObj;
    [Space]
    public float alertRange;
    public float walkAlertRange;
    public float runAlertRange;
    
    public Transform objectDestination;

    private Animator anim;
    [SerializeField]
    Vector3 lastPos;

    #endregion


    void Awake()
    {
        inputActions = new InputActions();

        inputActions.InGame.Jump.performed += _ => Jump();

        inputActions.InGame.Sprint.started += _ => StartSprint();
        inputActions.InGame.Sprint.canceled += _ => StopSprint();

        inputActions.InGame.Grab.performed += _ => GrabObj();

        inputActions.InGame.UseItem.performed += _ => ThrowObj();

        inputActions.InGame.Crouch.performed += _ => Crouch();
        inputActions.InGame.Crouch.performed += _ => Stand();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        cam = GetComponentInChildren<Camera>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move(inputActions.InGame.Move.ReadValue<Vector2>());

        if (transform.position == lastPos)
        {
            alertRange = 1f;
        }
        else if (transform.position != lastPos && moveSpeed == defaultSpeed)
        {
            alertRange = walkAlertRange;
        }
        else if (transform.position != lastPos && moveSpeed == runSpeed)
        {
            alertRange = runAlertRange;
        }
    }

    private void LateUpdate()
    {
        lastPos = transform.position;
    }

    private void FixedUpdate()
    {
        Collider[] hitCols = Physics.OverlapSphere(lastPos, alertRange);
        foreach(var hitCol in hitCols)
        {
            if(hitCol.gameObject.tag == "Enemy")
            {
                hitCol.gameObject.GetComponent<NavMeshAgent>().SetDestination(lastPos);
            }
        }
    }

    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void Move(Vector2 movement)
    {
        float h = (movement.x * moveSpeed * Time.deltaTime);
        float v = (movement.y * moveSpeed * Time.deltaTime);

        transform.Translate(h, 0, v);
    }

    void Jump()
    {
        if (IsGrounded())
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    void StartSprint()
    {
        moveSpeed = runSpeed;
    }
    void StopSprint()
    {
        if (isCrouching)
        {
            moveSpeed = crouchSpeed;
        }
        else
        {
            moveSpeed = defaultSpeed;
        }
    }


    public bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), 0.01f, groundLayers);
    }


    public void GrabObj()
    {
        if (grabbedObj == null)
        {
            RaycastHit theHit;

            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out theHit, grabRange))
            {
                TargetDistance = theHit.distance;

                GameObject grabbed = theHit.transform.gameObject;

                if (theHit.transform.gameObject.CompareTag("Throwable"))
                {
                    Debug.Log(grabbed.gameObject.name);
                    grabbed.GetComponent<Rigidbody>().useGravity = false;
                    grabbed.GetComponent<Rigidbody>().isKinematic = true;
                    grabbed.GetComponent<Collider>().enabled = false;
                    grabbed.transform.position = objectDestination.position;
                    grabbed.transform.parent = objectDestination.gameObject.transform;
                    grabbed.transform.rotation = objectDestination.rotation;
                    grabbedObj = grabbed;
                }
                else { Debug.Log(theHit.transform.gameObject.name); }
            }
        }
        else
        {
            grabbedObj.GetComponent<Rigidbody>().useGravity = true;
            grabbedObj.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObj.GetComponent<Collider>().enabled = true;
            grabbedObj.transform.parent = null;
            grabbedObj = null;
        }

    }

    public void ThrowObj()
    {
        if (grabbedObj != null && grabbedObj.tag == "Throwable")
        {
            grabbedObj.GetComponent<Rigidbody>().useGravity = true;
            grabbedObj.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObj.GetComponent<Collider>().enabled = true;
            grabbedObj.GetComponent<Throwable>().Throw();
            grabbedObj.transform.parent = null;
        }
    }
    public void Crouch()
    {
        isCrouching = true;
        moveSpeed = crouchSpeed;
        runSpeed = crouchRunSpeed;

        anim.Play("PlayerCrouching");
    }
    public void Stand()
    {

        isCrouching = false;
        moveSpeed = defaultSpeed;
        runSpeed = defaultRunSpeed;

        anim.Play("PlayerStanding");
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(transform.position, alertRange);
    }
}