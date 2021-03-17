using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] 
    public int _damage;
    [SerializeField]
    private GameObject _min;
    public GameObject explosion;
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
            Instantiate(explosion, transform.position, transform.rotation);
            if (reloadTimer > 0)
                reloadTimer -= Time.deltaTime; //если таймер перезарядки больше нуля - отнимаем его
            if (reloadTimer < 0)
                explosion.SetActive(false);
        }
    }
   
}
