using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] 
    public int _damage;
    [SerializeField]
    private GameObject _min;
    public GameObject _explosion;
    private float reloadTimer = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            print("Ouch:");
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            _min.SetActive(false);
            _explosion.SetActive(true);
            _explosion.GetComponent<StopBoom>().enabled = true;
            // // Instantiate(explosion, transform.position, transform.rotation);
            // if (reloadTimer > 0)
            //     reloadTimer -= Time.deltaTime; //если таймер перезарядки больше нуля - отнимаем его
            // // yield return new WaitForSeconds(3f);
            // if (reloadTimer < 0)
            //     _explosion.SetActive(false);
            // StartCoroutine(explosion());
            // explosion();
        }
    }

    // public IEnumerable explosion()
    // {
    //     yield return new WaitForSeconds(3f);
    //     _explosion.SetActive(false);
    // }
}
