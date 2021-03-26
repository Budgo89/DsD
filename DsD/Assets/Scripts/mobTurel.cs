using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTurel : MonoBehaviour
{
    [SerializeField] private Transform _player;
    // радиус стрельбы
    [SerializeField] private float _radius;
    [SerializeField] private float _distance;

    [SerializeField] private Rigidbody projectile;
    //скорость стрел
    [SerializeField] private float speedArrow = 4;
    //зона появления стрел
    [SerializeField] private Transform _arrowSpavner;
    [SerializeField] private float _reloadTimer = 30f; //задержка между выстрелами, изменяемое значение
    private float reloadTimer;
    void Start()
    {
        // InvokeRepeating("damagArrow(_radius, _distance)", 0, 5);
        reloadTimer = _reloadTimer;
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
                    DamagArrow(_radius, _distance);
                }
            }
        }
    }

    private void DamagArrow(float _radius, float _distance)
    {
        if (_distance < _radius)
        {
            Rigidbody p = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
            p.velocity = transform.forward * speedArrow;
        }
    }
}
