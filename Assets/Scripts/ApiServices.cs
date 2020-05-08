using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.SceneManagement;

public class ApiServices : MonoBehaviour
{

    UiAuth uiAuth;
    UnityWebRequest webRequest;
    readonly string webService = "http://localhost:3000/api";

    private void Start()
    {
        uiAuth = FindObjectOfType<UiAuth>();
    }

    IEnumerator TestRequest()
    {
        webRequest = UnityWebRequest.Get("http://localhost:3000/api/user/listUser/rafa");

        yield return webRequest.SendWebRequest();

        if (webRequest.isNetworkError)
        {
            Debug.Log("Error en la peticion");
        }
        else
        {
            Debug.Log(webRequest.downloadHandler.text);
        }
    }


    IEnumerator LoginUser(string email, string password) {

        WWWForm form = new WWWForm();

        form.AddField("email", email);
        form.AddField("password", password);

        webRequest = UnityWebRequest.Post($"{webService}/user/login", form);

        yield return webRequest.SendWebRequest();

        if (webRequest.isNetworkError)
        {
            Debug.Log("Error en la peticion");
        }
        else
        {
            if (webRequest.responseCode == 200)
            {
                var json = JSON.Parse(webRequest.downloadHandler.text);
                PlayerStorage.SaveId(json["user"]["email"],json["user"]["_id"]);
                SceneManager.LoadScene("Main");
            }
            else
            {
                Debug.Log("User o password incorrecto");
            }
        }

    }

    IEnumerator RegisterUser(string name,string email,string university,string password)
    {
        WWWForm form = new WWWForm();

        form.AddField("name",name);
        form.AddField("email",email);
        form.AddField("university",university);
        form.AddField("password",password);

        webRequest = UnityWebRequest.Post($"{webService}/user/create", form);

        yield return webRequest.SendWebRequest();

        if (webRequest.isNetworkError)
        {
            Debug.Log("Error en la peticion");
        }
        else
        {
            if (webRequest.responseCode == 200)
            {
              Debug.Log(webRequest.downloadHandler.text);
            }
        }
    }

    IEnumerator SaveAnswers()
    {
        WWWForm form = new WWWForm();

        webRequest = UnityWebRequest.Post("",form);

        yield return webRequest.SendWebRequest();
    }

    public void Login()
    {
        string email = uiAuth.GetDataLoginForm()[0].text;
        string password = uiAuth.GetDataLoginForm()[1].text;
        Debug.Log("AJA PAPI");

        StartCoroutine(LoginUser(email, password));

    }

    public void SingIn()
    {
        string name = uiAuth.GetDataLoginForm()[0].text;
        string email = uiAuth.GetDataLoginForm()[1].text;
        string university = uiAuth.GetDataLoginForm()[2].text;
        string password = uiAuth.GetDataLoginForm()[3].text;


        StartCoroutine(RegisterUser(name, email, university, password));

    }

}