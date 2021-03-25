using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitMenu : MonoBehaviour
{
    [SerializeField] private Button _restart;
    
    private void Awake()
    {
        _restart.onClick.AddListener(RestartLevel);
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }


}
