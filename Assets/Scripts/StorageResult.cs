using System;
using System.Collections.Generic;
using UnityEngine;

public class StorageResult 
{
    public List<string> id = new List<string>();
    public List<string> answerUser = new List<string>();
    public List<string> whyAnswers = new List<string>();
    private List<string> results = new List<string>();

    public List<string> GetAllResponse()
    {
        return results;
    }

    public void SaveAnswerUser(string questionId, string _answerUser , string _whyAnswers)
    {
        id.Add(questionId);
        answerUser.Add(_answerUser);
        whyAnswers.Add(_whyAnswers);
        results.Add($"{questionId}||{_answerUser}||{_whyAnswers}");
    }
}

