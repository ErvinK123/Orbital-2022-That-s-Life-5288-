using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextExplanation : MonoBehaviour
{
    public void choice1()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.scenarios, 1);

        //load new scene 
        string scene = "Explanation" + Player.scenarios + "1";
        SceneManager.LoadScene(scene);

    }


    public void choice2()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.scenarios, 2);

        //load new scene 
        string scene = "Explanation" + Player.scenarios + "2";
        SceneManager.LoadScene(scene);
    }

    public void choice3()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.scenarios, 3);

        //load new scene 
        string scene = "Explanation" + Player.scenarios + "3";
        SceneManager.LoadScene(scene);
    }

    public void choice4()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.scenarios, 4);

        //load new scene 
        string scene = "Explanation" + Player.scenarios + "4";
        SceneManager.LoadScene(scene);
    }
}
