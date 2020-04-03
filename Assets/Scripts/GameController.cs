using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public int indexQuiz;
    public int semesterLevel;
    private int endScore;

    private DataController dataController;
    private UiController uiController;
    private DataResult dataResult;
    private Round data;

    // Use this for initialization
    void Start()
    {
        dataController = FindObjectOfType<DataController>();
        uiController = FindObjectOfType<UiController>();
        dataResult = FindObjectOfType<DataResult>();

        indexQuiz = 0;
        endScore = 0;
        semesterLevel = 0; // Cambiar por el numero de semestre del usuario

        data = dataController.GetRoundData(semesterLevel);

        DisorderQuestion(data.questions);

        uiController.CreateButtonsAndInputs(data.questions[indexQuiz].answer,
            data.questions[indexQuiz]._id);
    }

    // Update is called once per frame
    void Update()
    {
        // setup ui text
        SetupUi(data.questions[indexQuiz].questionText,endScore);
    }

    public void CorrerAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            endScore += data.pointCorrectAnswer;
            uiController.endScore.text = endScore.ToString();
            NextQuestion();
        } else {
            NextQuestion();
        }
    }

    public void NextQuestion()
    {
        if ((indexQuiz+1)< data.questions.Length)
        {
            indexQuiz++;
            uiController.DeleteButtons();
            uiController.CreateButtonsAndInputs(data.questions[indexQuiz].answer
                ,data.questions[indexQuiz]._id);
            return;
        }
        EndLevel();
    }

    void SetupUi(string questionName, int points)
    {
        uiController.SetUiQuiz(questionName, points, data.name, (indexQuiz + 1)
            , data.questions.Length);
    }

    // TODO Hacer terminacion del modo quiz
    public void EndLevel()
    {
        Debug.Log("Fin de parcial");
        uiController.HandleGamePanel(false);
        GetDataRound();
    }

    public void GetDataRound()
    {
        Debug.Log("impresion de la data respondida");
        dataResult.GetData();
    }

    static void DisorderQuestion(Question[] arr)
    {
        for (var i = arr.Length - 1; i > 0; i--)
        {
            var r = Random.Range(0, i);
            var tmp = arr[i];
            arr[i] = arr[r];
            arr[r] = tmp;
        }
    }


}
