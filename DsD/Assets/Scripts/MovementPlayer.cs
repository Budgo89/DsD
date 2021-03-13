using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementPlayer : MonoBehaviour
{
    // Скорость персонажа
    [SerializeField]
    private float _speed;
    // Скорость прыжка персонажа
    [SerializeField]
    private float _jumpSpeed;
    [SerializeField]
    private Transform _mobTransform;
    // Гравитация
    private float gravity = 20.0f;
    // переменная движения персонажа
    private Vector3 moveDir = Vector3.zero;
    //переменная содержащая компонент CharacterController
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
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
            }

            moveDir.y -= gravity * Time.deltaTime;

            controller.Move(moveDir * Time.deltaTime);
        }


    }


    //private float Gravity = -9.81f;

    //private Vector3 _direction;
    //private CharacterController _characterController;
    //private Vector3 _velocity;
    //public float JumpHeight = 2f;
    //public float GroundDistance = 0.2f;
    //public float DashDistance = 5f;
    //private bool _isGrounded = true;
    //private Transform _groundChecker;
    //public LayerMask Ground;
    //[SerializeField] private Transform _target;


    //private void Start()
    //{
    //    _characterController = GetComponent<CharacterController>();
    //    _groundChecker = transform.GetChild(0);
    //}
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Q))
    //        RotateLeft();
    //    else if (Input.GetKeyDown(KeyCode.E))
    //        RotateRight();
    //    _isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
    //    if (_isGrounded && _velocity.y < 0)
    //        _velocity.y = 0f;
    //    float angle = Quaternion.Angle(transform.rotation, _target.rotation);
    //    print(angle);

    //    _direction.x = Input.GetAxis("Horizontal");
    //    _direction.z = -Input.GetAxis("Vertical");
    //    //if (angle <91 && angle > 89)
    //    //{
    //    //    _direction.x = Input.GetAxis("Horizontal");
    //    //    _direction.z = -Input.GetAxis("Vertical");
    //    //}
    //    //else if (angle < 136 && angle > 134)
    //    //{
    //    //    _direction.x = Input.GetAxis("Horizontal");
    //    //    _direction.z = -Input.GetAxis("Vertical");
    //    //}
    //    //transform.Translate(Vector3.forward * Time.deltaTime, Camera.main.transform);

    //    Vector3 move = new Vector3(_direction.z, 0, _direction.x);
    //    _characterController.Move(move * Time.deltaTime * _speed);
    //    if (Input.GetButtonDown("Jump") && _isGrounded)
    //        _velocity.y += Mathf.Sqrt(JumpHeight * -20f * Gravity);

    //    _velocity.y += Gravity * Time.deltaTime;
    //}
    //private void RotateLeft()
    //{
    //    transform.rotation *= Quaternion.Euler(0, -45, 0);
    //}
    //private void RotateRight()
    //{
    //    transform.rotation *= Quaternion.Euler(0, 45, 0);
    //} 
}

