using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneTransitions : MonoBehaviour
{
    public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float tiempo_end;//Segundos que queremos que pasen para que cambie de escena
                            // Update is called once per frame
    public Animator transitionAnim;
    public Text textDay;
    public string semesterNumber;
    public string semesterDay;
    private PlayDayController play;

    public string test;
    private void Start()
    {
        play = FindObjectOfType<PlayDayController>();
        settings(play.semesterDay, play.semesterNumber);
        textDay.text = $"Dia { Int32.Parse(semesterDay) + 1}";
    }

    void Update()
    {
        tiempo_start += Time.deltaTime;//Función para que la variable tiempo_start vaya contando segundos.
        if (tiempo_start >= tiempo_end){//Si pasan los segundos que hemos puesto antes...
            StartCoroutine(LoadScene());
        }
    }

    public void settings(string dia,string semestre)
    {
        semesterNumber = semestre;
        semesterDay = dia;
    }

    IEnumerator LoadScene()
    {
        Debug.Log(test);
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0f);

        // TODO si los dias aumentan cambiar la condicion

        Debug.Log(semesterDay);
        if (Int32.Parse(semesterDay)  < 4)
        {
            Debug.Log("entre");
            SceneManager.LoadScene($"SemesterDialog{semesterNumber}_{semesterDay}");
        }
        else
        {
            SceneManager.LoadScene("MenuQuiz");
        }


    }
}
