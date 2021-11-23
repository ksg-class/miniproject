using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
    public AudioMixer mv, sv;
    public AudioSource musicv, sfxv;
    public Slider sfx, music;
    private void Start()
    {
        sfx.value = PlayerPrefs.GetFloat("MusicVol");
        music.value = PlayerPrefs.GetFloat("SFXVolume");
    }
    private void Update()
    {
        musicv.volume = music.value;
        sfxv.volume = sfx.value;
    }
    public void VolumePrefs()
    {
        PlayerPrefs.SetFloat("Musicvol", music.value);
        PlayerPrefs.SetFloat("SFXVol", sfx.value);
    }
    public void Volume (float vol)
    {
        Debug.Log(vol);
        mv.SetFloat("MusicVol", vol);       
        sv.SetFloat("SFXVolume", vol);
    }
}
