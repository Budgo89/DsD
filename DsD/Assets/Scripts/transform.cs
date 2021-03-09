using System.Collections;
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
    }

    private void FixedUpdate()
    {
        var move = _direction * (_speed * Time.deltaTime);

        transform.Translate(move);
        if (Input.GetKeyDown(KeyCode.Q))
        {           
            // примерно секунду идет анимация, поэтому 0.95 секунды
            Invoke("RotateLeft", 0.04f);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Invoke("RotateRight", 0.04f);
        }


    }
    private void RotateLeft()
    {
        // анимация поворачивает персонажа на 90 градусов, поэтому 
        // программно задаем такой же угол поворота
        transform.rotation *= Quaternion.Euler(0, -90, 0);
    }

    private void RotateRight()
    {
        transform.rotation *= Quaternion.Euler(0, 90, 0);
    }
    //public float Speed = 2f;
    //public float JumpForce = 300f;

    //private bool _isGrounded;
    //private Rigidbody _rb;
    //void Start()
    //{
    //    _rb = GetComponent<Rigidbody>();
    //}
    //void FixedUpdate()
    //{
    //    MovementLogic();
    //    JumpLogic();
    //}
    //private void MovementLogic()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");

    //    float moveVertical = Input.GetAxis("Vertical");

    //    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    //    _rb.AddForce(movement * Speed);
    //}

    //private void JumpLogic()
    //{
    //    if (Input.GetAxis("Jump") > 0)
    //    {
    //        if (_isGrounded)
    //        {
    //            _rb.AddForce(Vector3.up * JumpForce);

    //            // Обратите внимание что я делаю на основе Vector3.up 
    //            // а не на основе transform.up. Если персонаж упал или 
    //            // если персонаж -- шар, то его личный "верх" может 
    //            // любое направление. Влево, вправо, вниз...
    //            // Но нам нужен скачек только в абсолютный вверх, 
    //            // потому и Vector3.up
    //        }
    //    }
    //}

    //void OnCollisionEnter(Collision collision)
    //{
    //    IsGroundedUpate(collision, true);
    //}

    //void OnCollisionExit(Collision collision)
    //{
    //    IsGroundedUpate(collision, false);
    //}

    //private void IsGroundedUpate(Collision collision, bool value)
    //{
    //    if (collision.gameObject.tag == ("Ground"))
    //    {
    //        _isGrounded = value;
    //    }
    //}
}

