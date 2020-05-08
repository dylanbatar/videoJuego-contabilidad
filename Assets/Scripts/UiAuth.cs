using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiAuth : MonoBehaviour
{
    public GameObject LoginPanel;
    public GameObject RegisterPanel;

    public InputField[] LoginInputField;
    public InputField[] RegisterInputField;

    private void Start()
    {
        HandlerPanls(true);
    }

    public void HandlerPanls(bool active)
    {
        LoginPanel.SetActive(active);
        RegisterPanel.SetActive(!active);
    }

    public InputField[] GetDataLoginForm()
    {
        return LoginInputField;
    }

    public InputField[] GetDataRegisterForm()
    {
        return RegisterInputField;
    }
}