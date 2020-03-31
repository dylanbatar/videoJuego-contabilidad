using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public Text textButton;
    private Answer answerData;
    private GameController gamecontroller;

    // Use this for initialization
    void Start()
    {

    }


    public void Setup(Answer data)
    {
        answerData = data;
        textButton.text = answerData.answer;
    }

    public void ClickButton() {
        gamecontroller.CorrerAnswer(answerData.isCorrect);
    }
}
