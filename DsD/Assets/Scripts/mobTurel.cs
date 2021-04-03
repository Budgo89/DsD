using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTurel : MonoBehaviour
{
    [SerializeField] private Transform _player;
    // радиус стрельбы
    [SerializeField] public float _radius;
                     public float _distance;

    [SerializeField] private Rigidbody projectile;
    //скорость стрел
    [SerializeField] private float speedArrow = 4;
    //зона появления стрел
    [SerializeField] private Transform _arrowSpavner;
    [SerializeField] private float _reloadTimer = 30f; //задержка между выстрелами, изменяемое значение
    [SerializeField] private AudioSource _audioSource;
    private float reloadTimer;
    private Animator _anim;
    void Start()
    {
        reloadTimer = _reloadTimer;
        _anim = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
    }

    void Update()
    {
        if (_player != null)
        {
            _distance = Vector3.Distance(_player.position, transform.position);
            if (_distance <= _radius)
            {
                var relativePos = _player.position - transform.position;
                var rotation = Quaternion.LookRotation(relativePos);
                transform.rotation = rotation;
                if (reloadTimer > 0) reloadTimer -= Time.deltaTime; //если таймер перезарядки больше нуля - отнимаем его
                if (reloadTimer < 0)
                {
                    reloadTimer = _reloadTimer;
                    _anim.SetBool("DrawArrowMob", true);
                    Invoke("DamagArrow",0.8f);
                    // DamagArrow(_radius, _distance);
                }
            }
        }
    }

    private void DamagArrow()
    {
        if (_distance < _radius)
        {
            Rigidbody arrow = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
            arrow.velocity = transform.forward * speedArrow;
            _audioSource.Play();
        }
    }
    
}
