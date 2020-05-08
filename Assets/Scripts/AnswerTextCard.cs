using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AnswerTextCard : MonoBehaviour
{
    public Text numberText;
    public Text answerText;
    public Text answerWhy;


    public void SetupAnswer(int index, string _answerText, string _answerWhy)
    {
        numberText.text = $"{index}";
        answerText.text = _answerText;
        answerWhy.text = _answerWhy;
    }
}
