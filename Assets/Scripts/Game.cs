using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Replic.Replics;

public class Game : MonoBehaviour
{
    public Data data;
    public Replic ru, en;
    public string scene;
    public int num;
    public Replic replic;
    public Fon fon;

    private void Start()
    {
        if (data.language == "ru")
        {
            replic = ru;
        }
        else 
        {
            replic = en;
        }
        fon.PlayAnim(replic.nodes[num].trigger);
    }
    private void OnEnable()
    {
        QuestFild.sedd += NextScene;
    }
    public void OnDisable()
    {
        QuestFild.sedd -= NextScene;
    }
    public void NextScene(int n) 
    {
        if (replic.nodes[num].tip == TipeOfTale.quest)
        {
            num = n;
            fon.PlayAnim(replic.nodes[n].trigger);
        }
        else 
        {
            if (replic.nodes[num].tip == TipeOfTale.dan)
            {
                PlayerPrefs.SetString("Level",scene);
                if (scene == "")
                {
                    SaveAndLoad.rid.Main();
                }
                else 
                {
                    SceneManager.LoadScene(scene);
                }
            }
            if (replic.nodes[num].tip == TipeOfTale.masage)
            {
                num = n;
                fon.PlayAnim(replic.nodes[n].trigger);
            }
        }

    }
}
