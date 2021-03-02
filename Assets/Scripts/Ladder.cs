using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ladder : MonoBehaviour
{
    public Transform CharacterCon;
    public bool IsNear = false;
    public float UpDownSpeed = 3.2f;
    public PlayerController playerCon;
    public InputActions inputActions;
    Vector2 moveInput;

    void Start()
    {

        playerCon = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

        IsNear = false;
    }

    void Awake()
    {
        inputActions = new InputActions();
    }

    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerCon.enabled = false;
            IsNear = !IsNear;

            playerCon.gameObject.GetComponent<Rigidbody>().useGravity = false;

        }
    }

    void OnCollisionExit(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerCon.enabled = true;
            IsNear = !IsNear;

            playerCon.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    void Update()
    {
        moveInput = inputActions.InGame.Move.ReadValue<Vector2>();

        if (IsNear == true && moveInput.y > 0.1f)
        {
            playerCon.transform.position += Vector3.up * UpDownSpeed * Time.deltaTime;
            
        }

        if (IsNear == true && moveInput.y <- 0.1f)
        {
            playerCon.transform.position += Vector3.down * UpDownSpeed * Time.deltaTime;

            if (playerCon.IsGrounded())
            {
                playerCon.enabled = true;
            }
        }
    }
}
