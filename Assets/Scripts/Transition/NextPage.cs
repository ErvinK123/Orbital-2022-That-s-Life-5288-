using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class NextPage : MonoBehaviour
{
    //number of scenarios per phase of life
    // can be randomized 
    public static int numberOfScene = 5;

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
            SceneManager.LoadScene("StandardIntro1"); // Have to change this intro according to the randomised stats
        }
    }

    public void back()
    {
        SceneManager.LoadScene("StartPage");
    }

    void Start()
    {   
        // sizes of each pool
        int childScene = 6;
        
        int teenScene = 6;
        int teen1frScene = 1;
        int teen2frScene = 0;
        int teen1enScene = 0;
        
        int adultScene = 6;
        int adult1frScene = 1;
        int adult2frScene = 0;
        int adult1enScene = 0;
        
        int elderlyScene = 6;
        int elderly1frScene = 1;
        int elderly2frScene = 0;
        int elderly1enScene = 0;

        int fLimit = 1;
        int enLimit = 0;
        Player.setFElimits(fLimit, enLimit);
        Player.setUpScenarios(childScene, teenScene, teen1frScene, teen2frScene, teen1enScene, 
            adultScene, adult1frScene,adult2frScene, adult1enScene,
            elderlyScene, elderly1frScene, elderly2frScene,elderly1enScene);
        Player.allocateChild();

    }
}

