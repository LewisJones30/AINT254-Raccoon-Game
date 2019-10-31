﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer m_audioMixer;
    [SerializeField]
    Slider volSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMusicVolume(float volume)
    {
        m_audioMixer.SetFloat("VolAmbient", volume);
    }

}