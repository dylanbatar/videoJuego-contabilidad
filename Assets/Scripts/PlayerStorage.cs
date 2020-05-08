using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStorage : MonoBehaviour
{
    static public void SaveId(string email,string _id)
    {
        PlayerPrefs.SetString("iduser", _id);
        PlayerPrefs.SetString("email", email);
    }

    static public string GetUser(string key)
    {
        return PlayerPrefs.GetString(key);
    }

    static public void Delete(string key)
    {
        PlayerPrefs.DeleteKey(key);
    }
}
