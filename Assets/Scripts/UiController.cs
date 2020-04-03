using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UiController : MonoBehaviour
{
    public Text titleQuestion;
    public Text endScore;
    public Text semesterName;
    public Text QuestionNumber;
    public Transform answerButtonPanel;
    public GameObject quizGamePanel;
    public GameObject resultPanel;
    public GameObject prefabButton;
    private int answerNumber;  // para manipular cuantos botones se crean

    // OPTIONAL en caso de que se decida que los parciales tengan tiempo activar
    //public Text timeQuiz;

    public void CreateButtonsAndInputs(Answer[] data,string idButton)
    {
        answerNumber = data.Length;
        for (int i = 0; i < answerNumber; i++)
        {
            GameObject answerButtonGameObject = Instantiate(prefabButton);
            answerButtonGameObject.transform.SetParent(answerButtonPanel);

            AnswerButton answerButton = answerButtonGameObject
                .GetComponent<AnswerButton>();
            answerButton.Setup(data[i],idButton);
        }
    }

    public void DeleteButtons()
    {
        for (int i = 0; i < answerNumber; i++)
        {
            Destroy(answerButtonPanel.GetChild(i).gameObject);
        }
    }

    /*
     * Se encarga de pasarle los datos a los elementos visuales del juego 
    */
    public void SetUiQuiz(string _questionName,int _points ,
        string _semesterName, int _start, int _end)
    {
        titleQuestion.text = _questionName;
        endScore.text = $"{_points}";
        semesterName.text = $"Jugando: {_semesterName}";
        QuestionNumber.text = $"{_start}/{_end}";
    }

    /*
    * Manipular que panel se muestra en el juego
    * si el {isActive} es false se va a mostrar el panel de resultados
    * si es true se va a motrar el juego
    */
    public void HandleGamePanel(bool isActive)
    {
        quizGamePanel.SetActive(isActive);
        resultPanel.SetActive(!isActive);
    }
}

