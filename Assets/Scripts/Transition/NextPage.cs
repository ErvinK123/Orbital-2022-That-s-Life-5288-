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
        int childScene = 4;
        
        int teenScene = 4;
        int teen1frScene = 0;
        int teen2frScene = 0;
        int teen1enScene = 0;
        
        int adultScene = 4;
        int adult1frScene = 0;
        int adult2frScene = 0;
        int adult1enScene = 0;
        
        int elderlyScene = 4;
        int elderly1frScene = 0;
        int elderly2frScene = 0;
        int elderly1enScene = 0;
        Player.setUpScenarios(childScene, teenScene, teen1frScene, teen2frScene, teen1enScene, 
            adultScene, adult1frScene,adult2frScene, adult1enScene,
            elderlyScene, elderly1frScene, elderly2frScene,elderly1enScene);
        Player.allocateChild();

    }
}

