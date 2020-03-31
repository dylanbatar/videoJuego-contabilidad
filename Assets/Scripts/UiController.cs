using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UiController : MonoBehaviour
{

    public Text titleQuestion;
    public Text endScore;
    public Transform answerButtonPanel;
    public GameObject prefabButton;

    // OPTIONAL en caso de que se decida que los parciales tengan tiempo activar
    //public Text timeQuiz;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateButtonsAndInputs(Answer[] data)
    {

        for (int i = 0; i < data.Length; i++)
        {
            GameObject answerButtonGameObject = Instantiate(prefabButton);
            answerButtonGameObject.transform.SetParent(answerButtonPanel);

            AnswerButton answerButton = answerButtonGameObject.GetComponent<AnswerButton>();
            answerButton.Setup(data[i]);
        }

    }


    public void DeleteButtons()
    {

    }
}

