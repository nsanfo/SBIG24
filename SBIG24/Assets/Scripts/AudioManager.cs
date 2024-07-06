using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = new AudioManager();
    public AudioSource musicSource;
    public AudioSource SFXSource;
    public AudioSource[] musicActivators;
    public AudioClip fallingPipe;
    public AudioClip railGrind;
    public AudioClip jumpWhoosh;

    private void Awake() {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void playClip(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }
}
