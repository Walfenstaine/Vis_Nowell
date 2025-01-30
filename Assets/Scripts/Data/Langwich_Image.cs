using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Langwich_Image : MonoBehaviour
{
    public Data data;
    public Image img;
    public Sprite[] sprit;

    private void FixedUpdate()
    {
        if (data.language == "ru")
        {
            img.sprite = sprit[0];
        }
        else 
        {
            img.sprite = sprit[1];
        }
    }
}
