using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("УРОВЕНЬ ПРОЙДЕН! Уровень 2 в разроботке");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
