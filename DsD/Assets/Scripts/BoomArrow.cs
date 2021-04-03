using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomArrow : MonoBehaviour
{
    [SerializeField] private Rigidbody projectile;
    [SerializeField] private float speed = 4;
    [SerializeField] private Transform _arrowSpavner;
    [SerializeField] private AudioSource _audioSource;
    private Animator _anim;

    public void Awake()
    {
        _anim = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
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
        _audioSource.Play();
    }
}
