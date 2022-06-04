using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextExplanation : MonoBehaviour
{
    public void choice1()
    {
        //store choice 
        Player.storeChoice(1);

        //load new scene
        
        string next = Player.getNextSceneName(1);
        SceneManager.LoadScene(next);

    }


    public void choice2()
    {
        //store choice 
        Player.storeChoice(2);

        //load new scene 
        string next = Player.getNextSceneName(2);
        SceneManager.LoadScene(next);
    }

    public void choice3()
    {
        //store choice 
        Player.storeChoice(3);

        //load new scene 
        string next = Player.getNextSceneName(3);
        SceneManager.LoadScene(next);
    }

    public void choice4()
    {
        //store choice 
        Player.storeChoice(4);

        //load new scene 
        string next = Player.getNextSceneName(4);
        SceneManager.LoadScene(next);
    }
}
