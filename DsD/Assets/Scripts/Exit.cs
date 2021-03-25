using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] private GameObject _exit;
    private void OnTriggerEnter(Collider other)
    {
        _exit.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        // print("УРОВЕНЬ ПРОЙДЕН! Уровень 2 в разроботке");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
