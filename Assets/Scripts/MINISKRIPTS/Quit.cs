using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void Onclick() 
    {
        SaveAndLoad.rid.Save();
        Quiter();
    }
    void Quiter() 
    {
        Application.Quit();
    }
}
