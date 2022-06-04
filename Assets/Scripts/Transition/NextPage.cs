using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextPage : MonoBehaviour
{
    public static int numberOfScene = 2; 

    public void next()
    {
        if (Player.name == null || Player.name == "") 
        {
            Player.nameReset();
            SceneManager.LoadScene("NameErrorEmpty");
        } else if (Player.name.Length > 10)
        {
            Player.nameReset(); 
            SceneManager.LoadScene("NameErrorLong");
            
        } else
        {
            SceneManager.LoadScene("Introduction");
        }
    }

    public void back()
    {
        SceneManager.LoadScene("StartPage");
    }

    void Start()
    {
        int childScene = 3;
        int teenScene = 3;
        int adultScene = 3;
        int elderlyScene = 3; 
        Player.setUpScenarios(childScene, teenScene, adultScene, elderlyScene);
        Player.allocateScenarios(); 

    }
}

