using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variator : MonoBehaviour
{
    public Game game;
    public Data data;
    public Text masage;
    public GameObject buton;

    private void OnEnable()
    {
        QuestFild.sedd += Clear;
        Fon.dan += Resive;
    }
    private void OnDisable()
    {
        QuestFild.sedd -= Clear;
        Fon.dan -= Resive;
    }
    void Resive() 
    {
        for (int i = 0; i < game.replic.nodes[game.num].questions.Length; i++) 
        {
            GameObject g = Instantiate(buton);
            g.transform.SetParent(transform);
            g.GetComponent<QuestFild>().numReplik = game.replic.nodes[game.num].questions[i].number_vet;
            g.GetComponent<QuestFild>().rep = game.replic.nodes[game.num].questions[i].quest;
        }
        masage.text = game.replic.nodes[game.num].masage;
    }
    void Clear(int n) 
    {
        masage.text = "";
    }
}
