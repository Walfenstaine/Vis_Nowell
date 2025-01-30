using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaineMenue : MonoBehaviour
{
    public AudioClip clip;
    public void Onclick()
    {
        SoundPlayer.regit.Play(clip);
       // Destroy(GameObject.FindWithTag("Sound"));
        SaveAndLoad.rid.Main();

    }
}
