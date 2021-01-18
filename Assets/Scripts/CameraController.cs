using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    #region variables
    public InputActions inputActions;
    public GameObject playerObj;

    public float sensitivity = 1f;
    public float ySensMultiplier = .8f;
    public Vector2 mouseInput;
    #endregion

    void Awake()
    {
        inputActions = new InputActions();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void Update()
    {
        mouseInput = new Vector2(inputActions.InGame.LookX.ReadValue<float>(), inputActions.InGame.LookY.ReadValue<float>());

        Vector2 selfRot = new Vector2(mouseInput.y, 0) * (sensitivity * ySensMultiplier) * Time.deltaTime;
        Vector2 fullRot = new Vector2(0, mouseInput.x) * sensitivity * Time.deltaTime;

        transform.Rotate(selfRot);
        playerObj.transform.Rotate(fullRot);

        float x = transform.localEulerAngles.x;
        
        ClampAngle(x, -66, 66);

        transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, 0);
    }

    float ClampAngle(float angle, float min, float max)
    {
        if(angle < 0f)
            angle = 360 + angle;
        if(angle > 180f)
            return Mathf.Max(angle, 360 + min);
        
        return Mathf.Min(angle, max);
    }
}
