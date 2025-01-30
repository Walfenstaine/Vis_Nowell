using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandStarter : MonoBehaviour
{
    public AudioClip clip;

    public void Onclick()
    {
        SoundPlayer.regit.Play(clip);
        SaveAndLoad.rid.Starter();
    }
}
