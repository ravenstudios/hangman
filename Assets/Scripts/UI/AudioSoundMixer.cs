using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSoundMixer : MonoBehaviour
{

    
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider fxSlider;
    [SerializeField] Slider masterSlider;
    // Start is called before the first frame update


    private void Awake()
    {
        fxSlider.onValueChanged.AddListener(SetFXVolume);
        masterSlider.onValueChanged.AddListener(SetMasterVolume);
    }

    private void SetMasterVolume(float vol)
    {
        mixer.SetFloat("MasterLevel", vol);
    }

    private void SetFXVolume(float vol)
    {
        mixer.SetFloat("SoundFXLevel", vol);
        
    }
}
