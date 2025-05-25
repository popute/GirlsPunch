using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite[] iconNumber;
    public GameObject Button;
    int StateGirls = 0;

    public int whitchButton=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button.GetComponent<Image>().sprite = iconNumber[StateGirls]; // 最初に表示するメスガキ
    }

    public void OnButtonClick()
    {
        if (whitchButton == 0)
        {
            NextImage();
        }
        else if (whitchButton == 1)
        {
            PreviousImage(); 
        }
    }

    // Update is called once per frame
    void NextImage()
    {
        StateGirls++;

        if (StateGirls >= iconNumber.Length)
        {
            StateGirls = 0; // 最後までいったら最初に戻る
        }

        Button.GetComponent<Image>().sprite = iconNumber[StateGirls];
    }

    void PreviousImage()
    {
        StateGirls--;

        if (StateGirls < 0)
        {
            StateGirls = iconNumber.Length - 1; // 最初を超えたら最後に戻る
        }

        Button.GetComponent<Image>().sprite = iconNumber[StateGirls];
    }
}
