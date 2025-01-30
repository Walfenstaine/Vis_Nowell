using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestFild : MonoBehaviour
{
    public AudioClip clip;
    public int numReplik;
    public string rep;
    public Text text;
    public static event Action<int> sedd;

    private void OnEnable()
    {
        QuestFild.sedd += Dess;
    }
    public void OnDisable()
    {
        QuestFild.sedd -= Dess;
    }
    private void Start()
    {
        text.text = rep;
    }
    public void Click() 
    {
        SoundPlayer.regit.Play(clip);
        sedd.Invoke(numReplik);
    }

    void Dess(int n) 
    {
        Destroy(gameObject,0.1f);
    }
}
