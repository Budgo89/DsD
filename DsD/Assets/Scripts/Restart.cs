using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _restert;
    [SerializeField] private TMP_Text _text;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        var enemy = _player.gameObject.GetComponent<MyEnemy>()._health;
        if (enemy <= 0)
         Invoke("Rect",3); 
    }

    private void Rect()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        _restert.SetActive(true);
        _text.text = "Вы проиграли! \nПопробуйте ещё раз.";
    }
}
