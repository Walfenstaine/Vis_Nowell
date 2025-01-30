using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public SoundMixer mixer;
    public AudioSource sorse;
    public static SoundPlayer regit { get; set; }
    private float tim;

    void Awake()
    {
        if (regit == null)
        {
            DontDestroyOnLoad(gameObject);
            regit = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void OnDestroy()

    {
        regit = null;
    }

    public void Play(AudioClip clip)
    {
        if (sorse.enabled) 
        {
            for (int i = 0; i < mixer.cenel.Length; i++)
            {
                if (mixer.cenel[i].clip.name == clip.name) 
                {
                    if (Time.time > tim)
                    {
                        sorse.PlayOneShot(mixer.cenel[i].clip, mixer.cenel[i].volume);
                        tim = Time.time + 0.01f;
                    }
                }
            }
            
            
        }
        
    }

}
