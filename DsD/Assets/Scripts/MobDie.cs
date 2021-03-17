using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDie : MonoBehaviour
{
    [SerializeField]
    public int _health;

    public void Hurt(int damage)
    {
        print("Ouch:" +damage);

        _health -= damage; ;

        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
