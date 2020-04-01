using System;
using System.Collections.Generic;
using UnityEngine;

public class StorageResult : MonoBehaviour
{
    public List<string> id = new List<string>();
    public List<string> answerUser = new List<string>();
    public List<string> whyAnswers = new List<string>();

    public void GetAllResponse()
    {
        Debug.Log(answerUser.Count);
        for (int i = 0; i < id.Count; i++)
        {
            Debug.Log($"pregunta {id[i]}: respuesta {answerUser[i]} ");
        }
    }

    public void SaveAnswerUser(string questionId, string _answerUser , string _whyAnswers)
    {
        id.Add(questionId);
        answerUser.Add(_answerUser);
        whyAnswers.Add(_whyAnswers);
    }
}

