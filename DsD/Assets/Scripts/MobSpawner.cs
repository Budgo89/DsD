using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _mob;
    [SerializeField]
    private GameObject _spawn;
    //Дверь
    [SerializeField]
    private GameObject _door;
   private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.GetComponent<MyEnemy>())
        {  
            print("ПОЯВИЛСЯ БОСС");
            _spawn.SetActive(false);
            _door.SetActive(false);
            _mob.SetActive(true);
        }
    }
}
