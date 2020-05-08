using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayDayController : MonoBehaviour
{
    private UiLevelController uiController;
<<<<<<< HEAD
    private SceneTransitions transitions;
    public int indexPanel;

    public string semesterNumber;
    public string semesterDay;
=======
    int indexPanel;
>>>>>>> 7a9a49469947abf1a57e792789e092cf7995ff2a

    private void Start()
    {
        uiController = FindObjectOfType<UiLevelController>();
<<<<<<< HEAD
        DontDestroyOnLoad(gameObject);
=======
>>>>>>> 7a9a49469947abf1a57e792789e092cf7995ff2a
    }

    public void HidePanelSemester()
    {
        uiController.daysText.SetActive(false);
        uiController.gridContainePanel.GetChild(indexPanel).gameObject
            .SetActive(false);
    }

    public void HandlerChildContainer(int index)
    {
        indexPanel = index;
        uiController.daysText.SetActive(true);
        uiController.gridContainePanel.GetChild(index).gameObject
            .SetActive(true);
        SelectDay();
    }

    public void SelectDay()
    {
        Transform days = uiController.gridContainePanel.GetChild(indexPanel)
            .Find("ContainerDays");
<<<<<<< HEAD
=======

>>>>>>> 7a9a49469947abf1a57e792789e092cf7995ff2a
        for (int i = 0; i < days.childCount; i++)
        {
            Button button = days.GetChild(i).GetComponent<Button>();
            button.name = i.ToString();
            button.onClick.AddListener(() => PlayDay(indexPanel.ToString(),button.name));
        }
    }

<<<<<<< HEAD
    public void PlayDay(string semesterdialog, string day)
    {
        //transitions.HandlerText(day);
        semesterNumber = (semesterdialog);
        semesterDay = day;        
        SceneManager.LoadScene("TransicionDia");
=======
    public void PlayDay(string semester, string day)
    {
        SceneManager.LoadScene($"Semester{semester}_{day}");
>>>>>>> 7a9a49469947abf1a57e792789e092cf7995ff2a
    }

}

