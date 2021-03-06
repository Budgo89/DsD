using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementPlayer : MonoBehaviour
{
    // Скорость персонажа
    [SerializeField] private float _speed;
    // Скорость прыжка персонажа
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private Transform _mobTransform;
    // Гравитация
    private float gravity = 15f;
    // переменная движения персонажа
    private Vector3 moveDir = Vector3.zero;
    //переменная содержащая компонент CharacterController
    private CharacterController controller;
    private Animator _anim;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_mobTransform != null)
        {
            if (controller.isGrounded)
            {
                moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDir = transform.TransformDirection(moveDir);
                moveDir *= _speed;
            }

            if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
            {
                moveDir.y = _jumpSpeed;
                _anim.SetTrigger("Jump");
            }
                

            moveDir.y -= gravity * Time.deltaTime;

            controller.Move(moveDir * Time.deltaTime);
        }
    }
}

