using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public Text textButton;
    public InputField whyAnswer;
    private Answer answerData;
    private GameController gameController;

    // Use this for initialization
    void Start()
    {
        gameController = FindObjectOfType<GameController>();   
    }

    public void Setup(Answer data)
    {
        answerData = data;
        textButton.text = answerData.answer;
    }

    // TODO guardar estos datos
    public void ClickButton()
    {
        Debug.Log("Click");
        gameController.CorrerAnswer(answerData.isCorrect);
    }

    // TODO guardar estos datos
    public void HandleInputWhy()
    {
        Debug.Log($"{whyAnswer.text}"); 
    }
}
