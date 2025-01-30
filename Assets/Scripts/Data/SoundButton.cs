using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Data data;
    public Image image;
    public Sprite on, off;
    public AudioSource sorse;

    public void Start()
    {
        sorse = SoundPlayer.regit.sorse;
        sorse.enabled = data.soundOn;
        if (data.soundOn)
        {
            image.sprite = on;
        }
        else
        {
            image.sprite = off;
        }
        //YandexGame.SaveProgress();
    }
    public void Onclicker() 
    {
        data.soundOn = !data.soundOn;
        if (data.soundOn) 
        {
            image.sprite = on;
        }
        else
        {
            image.sprite = off;
        }
        sorse.enabled = data.soundOn;
    }
}
