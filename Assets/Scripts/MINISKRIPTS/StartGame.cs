using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Data data;
    void Start()
    {
        if (data.IsSaved) { Destroy(gameObject); }
    }

    public void Onclic() 
    {
        SaveAndLoad.rid.Starter();
    }
}
