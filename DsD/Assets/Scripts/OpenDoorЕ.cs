using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorЕ : MonoBehaviour
{
    [SerializeField] private GameObject _mob;
    [SerializeField] private GameObject _spawn;
    //Дверь
    [SerializeField] private GameObject _door;
    [SerializeField] private GameObject _Light;


    private Animator _animator;
    private Animator _animatorLight;
    
    private void Awake()
    {
        _animator = _door.gameObject.GetComponent<Animator>();
        _animatorLight = _Light.gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("ПОЯВИЛСЯ БОСС");
            _spawn.SetActive(false);
            _animator.SetTrigger("OpenDoor");
            _animatorLight.SetTrigger("OpenLight");
            _mob.SetActive(true);
        }
    }
}
