using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _restart;
    [SerializeField] private Button _control;
    [SerializeField] private Button _next;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _controlMenu;
    [SerializeField] private Button _audio;
    [SerializeField] private GameObject _audioMenu;
    
    private void Awake()
    {
        _restart.onClick.AddListener(RestartLevel);
        _control.onClick.AddListener(ControlMenuOpen);
        _next.onClick.AddListener(Next);
        _audio.onClick.AddListener(Audio);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    private void ControlMenuOpen()
    {
        _controlMenu.SetActive(true);
    }
    private void Next()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _menu.SetActive(false);
    }

    private void Audio()
    {
        _audioMenu.SetActive(true);
    }

    private void OnDestroy()
    {
        _restart.onClick.RemoveAllListeners();
        _control.onClick.RemoveAllListeners();
        _next.onClick.RemoveAllListeners();
        _audio.onClick.RemoveAllListeners();
        
    }
}
