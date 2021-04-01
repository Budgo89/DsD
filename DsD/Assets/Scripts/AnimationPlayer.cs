using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    private Animator _anim;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _anim.SetBool("Forward", true);
        }
        else
        {
            _anim.SetBool("Forward", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _anim.SetBool("Back", true);
        }
        else
        {
            _anim.SetBool("Back", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _anim.SetBool("RunRight", true);
        }
        else
        {
            _anim.SetBool("RunRight", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _anim.SetBool("RunLeft", true);
        }
        else
        {
            _anim.SetBool("RunLeft", false);
        }
    }
}
