using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _moveDir = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_moveDir);
    }

    private void Move(Vector2 dir)
    {
        _moveDir = dir;
    }

    private void ApplyMovement(Vector2 dir)
    {
        dir = dir * 5;

        _rigidbody.velocity = dir;
    }
}
