using UnityEngine;
using System.Collections.Generic;

public class DataResult : MonoBehaviour
{
    public StorageResult storage = new StorageResult();

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SaveData(string questionId, string userAnswer, string userWhyAnswer)
    {
        storage.SaveAnswerUser(questionId, userAnswer, userWhyAnswer);
    }

    public List<string> GetData()
    {
       return storage.GetAllResponse();
    }
}

