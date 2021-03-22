using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{

   private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.GetComponent<MyEnemy>())
        {  
            print("НАЖМИ Е ЧТО БЫ ОТКРЫТЬ ДВЕРЬ");
            GetComponent<OpenDoorЕ>().enabled = true;
        }
    }
}
