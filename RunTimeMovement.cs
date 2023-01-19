using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class RunTimeMovement : MonoBehaviour
{
    private Movement _input;
    private CharacterController _controller;
    [SerializeField] private float fraction;
    private Animator _anim;
    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<Movement>();
        _anim = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        _controller.Move(new Vector3((_input.moveValue.x*_input.moveSpeed)/ fraction, 0f,(_input.moveValue.y*_input.moveSpeed)/ fraction));
        _anim.SetFloat("speed", Mathf.Abs(_controller.velocity.x) * Mathf.Abs(_controller.velocity.z));
    }
}
