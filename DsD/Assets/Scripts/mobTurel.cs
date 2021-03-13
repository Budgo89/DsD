using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobTurel : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    // радиус стрельбы
    [SerializeField]
    private float _radius;
    private float _distance;

    [SerializeField]
    private Rigidbody projectile;
    [SerializeField]
    //скорость стрел
    private float speedArrow = 4;
    [SerializeField]
    //зона появления стрел
    private Transform _arrowSpavner;
    [SerializeField]
    private float _reloadTimer = 30f; //задержка между выстрелами, изменяемое значение
    float reloadTimer;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("damagArrow(_radius, _distance)", 0, 5);
        reloadTimer = _reloadTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (_player != null)
        {
            _distance = Vector3.Distance(_player.position, transform.position);
            if (_distance <= _radius)
            {
                Vector3 relativePos = _player.position - transform.position;
                Quaternion rotation = Quaternion.LookRotation(relativePos);
                transform.rotation = rotation;
                if (reloadTimer > 0) reloadTimer -= Time.deltaTime; //если таймер перезарядки больше нуля - отнимаем его
                if (reloadTimer < 0)
                {
                    reloadTimer = _reloadTimer;
                    damagArrow(_radius, _distance);

                }
                //print(reloadTimer);

            }
        }

    }

    private void damagArrow(float _radius, float _distance)
    {
        if (_distance < _radius)
        {
            Rigidbody p = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
            p.velocity = transform.forward * speedArrow;

        }

    }

}
