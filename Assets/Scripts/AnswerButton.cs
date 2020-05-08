using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    private string questionId;
    public Text textButton;
    public InputField whyAnswer;
    private Answer answerData;
    private GameController gameController;
    private DataResult dataResult;

    // Use this for initialization
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        dataResult = FindObjectOfType<DataResult>();
    }

    public void Setup(Answer data,string _questionId)
    {
        answerData = data;
        textButton.text = answerData.answer;
        questionId = _questionId;
    }

    public void ClickButton()
    {
        dataResult.SaveData(questionId, answerData.answer,$"Porque: {whyAnswer.text}");
        gameController.CorrerAnswer(answerData.isCorrect);
    }

    public void HandleInputWhy()
    {
        if (!whyAnswer) whyAnswer.text = "sin justificacion";
    }
}
