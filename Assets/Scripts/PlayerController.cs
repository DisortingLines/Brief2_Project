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

    [Space][Header("Variables")]
    public float moveSpeed = 3f;
    public float runSpeed = 5f;
    public float defaultSpeed = 3f;
    public float jumpVelocity = 5f;
    public LayerMask groundLayers;
    #endregion

    void Awake()
    {
        inputActions = new InputActions();

        inputActions.InGame.Jump.performed += _ => Jump();

        inputActions.InGame.Sprint.started += _ => StartSprint();
        inputActions.InGame.Sprint.canceled += _ => StopSprint();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
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
}