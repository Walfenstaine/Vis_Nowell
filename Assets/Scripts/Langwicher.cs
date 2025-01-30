using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Langwicher : MonoBehaviour
{
    public AudioClip clip;
    public Data data;
    public Slider slider;

    private void Start()
    {
        AudioSource sorse = SoundPlayer.regit.sorse;
        slider.value = sorse.volume;
    }
    private void FixedUpdate()
    {
        AudioSource sorse = SoundPlayer.regit.sorse;
        sorse.volume = slider.value;
    }
    public void Onlang(string s) 
    {
        data.language = s;
        PlayerPrefs.SetString("Language", s);
        SoundPlayer.regit.Play(clip);
    }
}
