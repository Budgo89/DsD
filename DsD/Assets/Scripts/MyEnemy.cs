using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    [SerializeField]
    public int _health = 1;

    //private void Update()
    //{
    //    print("Ouch:" + 1);

    //    _health -= 1; ;

    //    if (_health <= 0)
    //    {
    //        Die();            
    //    }
    //}
    public void Hurt(int damage)
    {
        print("Ouch:" +damage);

        _health -= damage; ;

        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
