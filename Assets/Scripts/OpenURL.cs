using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void OpenURLAdress(string url) 
    {
        Application.OpenURL(url);
    }
}
