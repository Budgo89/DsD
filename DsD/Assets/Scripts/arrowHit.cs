using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowHit : MonoBehaviour
{
    //[SerializeField]
    // public GameObject explosion;
    [SerializeField]
    public int _damage;
    //OnTriggerEnter
    //public void OnCollisionEnter(Collider other)
    public void OnTriggerEnter(Collider other)
    {
        // Instantiate(explosion, transform.position, transform.rotation);
        if (other.gameObject.CompareTag("Mob"))
            print("Попадание");
        if (other.tag == "Mob")
        {
            print("Урон");
            var enemy = other.GetComponent<MobKill>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            gameObject.SetActive(false);

        }
        //Destroy(gameObject);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Enemy"))
    //        print("Ouch:");
    //    if (other.tag == "Enemy")
    //    {
    //        var enemy = other.GetComponent<MyEnemy>();
    //        enemy.Hurt(_damage);
    //        Destroy(gameObject);
           
    //    }



    //}
}
