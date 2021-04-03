using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenDoorЕ : MonoBehaviour
{
    [SerializeField] private GameObject _mob;
    [SerializeField] private GameObject _spawn;
    //Дверь
    [SerializeField] private GameObject _door;
    [SerializeField] private GameObject _Light;
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private AudioSource _audioSource;


    private Animator _animator;
    private Animator _animatorLight;
    private void Awake()
    {
        _animator = _door.gameObject.GetComponent<Animator>();
        _animatorLight = _Light.gameObject.GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _hinr.text = "ПОЯВИЛСЯ БОСС";
            _animator.SetTrigger("OpenDoor");
            _animatorLight.SetTrigger("OpenLight");
            _mob.SetActive(true);
            _audioSource.Play();
            Invoke("SpawnOff",2f);
            Invoke("TimeOff",5.0f);
        }
    }

    private void TimeOff()
    {
        _hinr.text = " ";
    }

    private void SpawnOff()
    {
        _spawn.SetActive(false);
    }

}
