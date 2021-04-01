using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomArrow : MonoBehaviour
{
    [SerializeField]
    public Rigidbody projectile;
    [SerializeField]
    public float speed = 4;
    [SerializeField]
    public Transform _arrowSpavner;
    private Animator _anim;

    public void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _anim.SetTrigger("DrawArrow");
            Invoke("Draw",0.9f);

        }
    }

    private void Draw()
    {
        Rigidbody position = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
        position.velocity = transform.forward * speed;
    }
}
