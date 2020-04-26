using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;
using UnityEngine.UI;

public class DialogDisplay : MonoBehaviour
{
    public Conversation conversation;
    public GameObject speakerLeft;
    public GameObject speakerRight;
    private SpeakerUI speakerUILeft;
    private SpeakerUI speakerUIRight;
    public string semesterdialog;
    public string day;

    

    private int activeLineIndex = 0;
    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUI>();

        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUILeft.Speaker = conversation.speakerRight;

    
    }
    

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            AdvanceConversation();
        }

    }
 

   

   
    public void AdvanceConversation()
    {
        if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
           
        }
        else
        {
            speakerUILeft.Hide();
            speakerUIRight.Hide();
            activeLineIndex = 0;
            enviar();
        }
    }




    public void enviar()
    {
        SceneManager.LoadScene($"SemesterDialog{semesterdialog}_{day}");
        //SceneManager.LoadScene("SemesterDialog0_2", LoadSceneMode.Single);
    }

    void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        Character character = line.character;


        if (speakerUILeft.SpeakerIs(character))
        {
            SetDialog(speakerUILeft, speakerUIRight, line.text);
        }
        else
        {
            SetDialog(speakerUIRight, speakerUILeft, line.text);
        }
    }

    void SetDialog
    (
   SpeakerUI activeSpeakerUI,
            SpeakerUI inactiveSpeakerUI,
            string text
    )
    {
        activeSpeakerUI.Dialog = text;
        activeSpeakerUI.Show();

    }
}
