using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DataController : MonoBehaviour
{
    public Round[] allround;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("StartQuiz");
    }

    public Round GetRoundData(int round)
    {
        return allround[round];
    }

}
