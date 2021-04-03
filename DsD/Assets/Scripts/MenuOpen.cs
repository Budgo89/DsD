using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpen : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _controlMenu;
    [SerializeField] private GameObject _audioMenu;
    void Start()
    {
        _menu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && !_menu.activeInHierarchy)
        {
            _menu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _menu.activeInHierarchy)
        {
            _audioMenu.SetActive(false);
            _controlMenu.SetActive(false);
            _menu.SetActive(false);  
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
