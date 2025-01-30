using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Fon : MonoBehaviour
{
    public Animator anim;
    public static event Action dan;
    public bool isAnim;
    public float timer;

    public void Dan() 
    {
        dan.Invoke();
    }
    public void PlayAnim(string t) 
    {
        if (t != "") 
        {
            anim.SetTrigger(t);
        }
       
        Invoke("Dan", timer);
    }
}
