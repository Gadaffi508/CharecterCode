using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody capsule;
    public Vector2 moveValue;
    public float moveSpeed = 10;

    private void Awake()
    {
        capsule = GetComponent<Rigidbody>();
    }
    public void Moving(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            moveValue = value.ReadValue<Vector2>();
        }
        if (value.canceled)
        {
            moveValue = value.ReadValue<Vector2>();
        }
    }
}
