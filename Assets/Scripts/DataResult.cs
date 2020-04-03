using UnityEngine;
using System.Collections;

public class DataResult : MonoBehaviour
{
    private StorageResult storage = new StorageResult();

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SaveData(string questionId, string userAnswer, string userWhyAnswer)
    {
        storage.SaveAnswerUser(questionId, userAnswer, userWhyAnswer);
    }

    public void GetData()
    {
        storage.GetAllResponse();
    }
}

