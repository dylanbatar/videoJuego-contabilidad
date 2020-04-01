using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public int indexQuiz;
    public int semesterLevel;

    private DataController dataController;
    private static UiController uiController;

    Round data;
    int endScore;
    

    // Use this for initialization
    void Start()
    {
        dataController = FindObjectOfType<DataController>();
        uiController = FindObjectOfType<UiController>();

        indexQuiz = 0;
        endScore = 0;
        semesterLevel = 0; // Cambiar por el numero de semestre del usuario

        data =  dataController.GetRoundData(semesterLevel);

        DisorderQuestion(data.questions);

        uiController.CreateButtonsAndInputs(data.questions[indexQuiz].answer);

        // TODO pasar esta logica a componentes visuales
        Debug.Log("Nombre del semestre que se esta jugando");
        Debug.Log(data.name);

        Debug.Log("Numero de preguntas en el parcial");
        Debug.Log(data.questions.Length);

        Debug.Log("Respuesta correcta de la pregunta #1");
        for (int i = 0; i < data.questions[0].answer.Length; i++)
        {
            if (data.questions[0].answer[i].isCorrect)
            {
                Debug.Log(data.questions[0].answer[i].answer);
            }
        }
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
        }
        else
        {
            NextQuestion();
        }
    }

    public void NextQuestion()
    {
        if ((indexQuiz+1)<= data.questions.Length)
        {
            indexQuiz++;
            uiController.DeleteButtons();
            uiController.CreateButtonsAndInputs(data.questions[indexQuiz].answer);
            return;
        }

        Debug.Log("Fin de parcial");
    }


    void SetupUi(string questionName, int points)
    {
        uiController.titleQuestion.text = questionName;
        uiController.endScore.text = points.ToString();

    }

    // TODO Hacer terminacion del modo quiz
    public void EndLevel()
    {

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
