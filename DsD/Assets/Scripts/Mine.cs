using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] public int _damage;
    [SerializeField] private GameObject _min;
    [SerializeField] private AudioSource _audioSource;
    public GameObject _explosion;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            _audioSource.Play();
            _explosion.SetActive(true);
            _explosion.GetComponent<StopBoom>().enabled = true;
            Invoke("MinStop", 2f);
        }
    }

    private void MinStop()
    {
        _min.SetActive(false);
    }

}
