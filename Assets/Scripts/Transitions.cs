using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Transitions : MonoBehaviour
{
    public Text dayText;

    private void Awake()
    {
        dayText.text = "";
    }

    public void HandlerText(string day)
    {
        dayText.text = day;
    }



  
}
