using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] private Button _next;
    [SerializeField] private Slider _sliderOverallVolume;
    [SerializeField] private Slider _sliderMusic;
    [SerializeField] private Slider _sliderWorld;
    [SerializeField] private GameObject _audioMenu;
    [SerializeField] private AudioMixerGroup _audioOverallVolume;
    [SerializeField] private AudioMixerGroup _audioMusic;
    [SerializeField] private AudioMixerGroup _audioWorld;
    private void Awake()
    {
        _next.onClick.AddListener(Next);
        _sliderOverallVolume.onValueChanged.AddListener(number => OverallVolume(number));
        _sliderMusic.onValueChanged.AddListener(number => AudioMusic(number));
        _sliderWorld.onValueChanged.AddListener(number => AudioWorld(number));
    }
    private void Next()
    {
        _audioMenu.SetActive(false);
    }
    private void OverallVolume(float number)
    {
        _audioOverallVolume.audioMixer.SetFloat("masterVol",number);
    }
    
    private void AudioMusic(float number)
    {
        _audioMusic.audioMixer.SetFloat("musicVol",number);
    }

    private void AudioWorld(float number)
    {
        _audioWorld.audioMixer.SetFloat("wortdVol",number);
    }

    private void OnDisable()
    {
        _next.onClick.RemoveAllListeners();
    }
}
