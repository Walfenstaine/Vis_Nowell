using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndLoad : MonoBehaviour
{
    public Data data;

    public static SaveAndLoad rid { get; set; }
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if (PlayerPrefs.HasKey("Language"))
        {
            data.language = PlayerPrefs.GetString("Language");
        }
        if (PlayerPrefs.HasKey("Level"))
        {
            if (PlayerPrefs.HasKey("Issaved"))
            {
                data.IsSaved = true;
            }
            else 
            {
                data.IsSaved = false;
            }
            data.level = PlayerPrefs.GetString("Level");
        }
        else 
        {
            data.level = "Scene1";
        }
    }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(rid.gameObject);
        }
    }

    public void Starter() 
    {
        PlayerPrefs.DeleteAll();
        data.IsSaved = false;
        SceneManager.LoadScene("Scene1");
    }

    public void Load() 
    {
        SceneManager.LoadScene(data.level);
    }

    public void Save() 
    {
        data.IsSaved = true;
        PlayerPrefs.SetInt("Issaved", 1);
        PlayerPrefs.SetString("Level", data.level);
    }

    public void Main() 
    {
        SaveAndLoad.rid.Save();
        SceneManager.LoadScene("MainMenue local");
    }
}
