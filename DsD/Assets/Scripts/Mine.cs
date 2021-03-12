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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
            print("Ouch:");
        if (other.tag == "Enemy")
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            _min.SetActive(false);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
      }
   
}
