using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{


    public GameObject PauseUI;
    private bool paused = false;

    // Use this for initialization
    void Start()
    {
        PauseUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("pause"))
        {
            paused = !paused;
        }
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;

        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;

        }
    }
    public void Continuar()
    {
        paused = false;

    }
    public void Opciones()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
    public void Salir()
    {
        Application.Quit();
    }

}

