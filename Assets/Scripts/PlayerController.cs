using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    #region variables
    [Header("Components")]
    public InputActions inputActions;
    public Rigidbody rb;
    public CapsuleCollider col;
    public Camera cam;

    [Space][Header("Variables")]
    public float moveSpeed = 3f;
    public float runSpeed = 5f;
    public float defaultSpeed = 3f;
    public float jumpVelocity = 5f;
    public LayerMask groundLayers;
    public float TargetDistance;
    public float grabRange = 3f;
    public GameObject grabbedObj;

    public Transform objectDestination;
    #endregion


    void Awake()
    {
        inputActions = new InputActions();

        inputActions.InGame.Jump.performed += _ => Jump();

        inputActions.InGame.Sprint.started += _ => StartSprint();
        inputActions.InGame.Sprint.canceled += _ => StopSprint();

        inputActions.InGame.Grab.performed += _ => GrabObj();

        inputActions.InGame.UseItem.performed += _ => ThrowObj();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        Move(inputActions.InGame.Move.ReadValue<Vector2>());
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
        if(IsGrounded())
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
        moveSpeed = defaultSpeed;
    }

    bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), 0.01f, groundLayers);
    }

    public void GrabObj()
    {
        if(grabbedObj == null)
        {
            RaycastHit theHit;

            if (Physics.Raycast (cam.transform.position, cam.transform.forward, out theHit, grabRange))
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
                else{Debug.Log(theHit.transform.gameObject.name);}
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
        if(grabbedObj != null && grabbedObj.tag == "Throwable")
        {
            grabbedObj.GetComponent<Rigidbody>().useGravity = true;
            grabbedObj.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObj.GetComponent<Collider>().enabled = true;
            grabbedObj.GetComponent<Throwable>().Throw();
            grabbedObj.transform.parent = null;
        }
    }
}