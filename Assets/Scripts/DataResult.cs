using UnityEngine;
<<<<<<< HEAD
using System.Collections.Generic;

public class DataResult : MonoBehaviour
{
    public StorageResult storage = new StorageResult();
=======
using System.Collections;

public class DataResult : MonoBehaviour
{
    private StorageResult storage = new StorageResult();
>>>>>>> 7a9a49469947abf1a57e792789e092cf7995ff2a

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SaveData(string questionId, string userAnswer, string userWhyAnswer)
    {
        storage.SaveAnswerUser(questionId, userAnswer, userWhyAnswer);
    }

<<<<<<< HEAD
    public List<string> GetData()
    {
       return storage.GetAllResponse();
=======
    public void GetData()
    {
        storage.GetAllResponse();
>>>>>>> 7a9a49469947abf1a57e792789e092cf7995ff2a
    }
}

