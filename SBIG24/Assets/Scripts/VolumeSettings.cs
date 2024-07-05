using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer myMixer;
    public GameObject OptionsPanel;

    public Slider masterSlider;
    public Slider musicSlider;
    public Slider SFXSlider;

    private void Start() {
        SetMasterVolume();
        SetMusicVolume();
        SetSFXVolume();

        OptionsPanel.SetActive(false);
    }

    public void SetMasterVolume(){
        myMixer.SetFloat("Master", Mathf.Log10(masterSlider.value) * 20);
    }
    public void SetMusicVolume(){
        myMixer.SetFloat("Music", Mathf.Log10(musicSlider.value) * 20);
    }
    public void SetSFXVolume(){
        myMixer.SetFloat("SFX", Mathf.Log10(SFXSlider.value) * 20);
    }
}
