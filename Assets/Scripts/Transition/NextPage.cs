using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextPage : MonoBehaviour
{
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
        int numberOfScenarios = 2;
        Player.setUpScenarios(numberOfScenarios);
        Player.allocateScenarios(); 

    }
}

