using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField] private TMP_Text _hinr;

   private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.GetComponent<MyEnemy>())
        {  
            _hinr.text = "Нажтите Е что бы открыть дверь";
            GetComponent<OpenDoorЕ>().enabled = true;
        }
    }

   private void OnTriggerExit(Collider other)
   {
       _hinr.text = " ";
       GetComponent<OpenDoorЕ>().enabled = false;
   }
}
