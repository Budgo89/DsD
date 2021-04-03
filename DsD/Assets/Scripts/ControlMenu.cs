using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMenu : MonoBehaviour
{
    [SerializeField] private Button _next;
    [SerializeField] private GameObject _controlMenu;

    private void Awake()
    {
        _next.onClick.AddListener(Next);
    }


    private void Next()
    {
        _controlMenu.SetActive(false);
    }

    private void OnDisable()
    {
        _next.onClick.RemoveAllListeners();
    }
}
