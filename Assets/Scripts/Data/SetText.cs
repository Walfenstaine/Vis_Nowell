using UnityEngine;
using UnityEngine.UI;

public class SetText: MonoBehaviour
{
    public Data data;
    [SerializeField] 
    private Language language;

    private void FixedUpdate()
    {
        Text myText = GetComponent<Text>();
        if (data.language == "ru")
        {
            myText.text = language.ru;
        }
        else
        {
            myText.text = language.en;
        }
    }
}
