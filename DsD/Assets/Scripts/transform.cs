﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class transform : MonoBehaviour
{
    bool facingRight;
    [SerializeField]
    private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RotateLeft();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            RotateRight();
        }
    }

    private void FixedUpdate()
    {
        var move = _direction * (_speed * Time.deltaTime);

        transform.Translate(move);

    }
    private void RotateLeft()
    {

        transform.rotation *= Quaternion.Euler(0, -90, 0);
    }

    private void RotateRight()
    {
        transform.rotation *= Quaternion.Euler(0, 90, 0);
    }
   
}

