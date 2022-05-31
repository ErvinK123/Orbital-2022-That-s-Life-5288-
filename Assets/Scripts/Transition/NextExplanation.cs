using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextExplanation : MonoBehaviour
{
    public void choice1()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.alottedRound[Player.scenarios - 1], 1);

        //load new scene
        string scene = Player.age + Player.alottedRound[Player.scenarios -1].id + "E1";
        SceneManager.LoadScene(scene);

    }


    public void choice2()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.alottedRound[Player.scenarios - 1], 2);

        //load new scene 
        string scene = Player.age + Player.alottedRound[Player.scenarios - 1].id + "E2";
        SceneManager.LoadScene(scene);
    }

    public void choice3()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.alottedRound[Player.scenarios - 1], 3);

        //load new scene 
        string scene = Player.age + Player.alottedRound[Player.scenarios - 1].id + "E3";
        SceneManager.LoadScene(scene);
    }

    public void choice4()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.alottedRound[Player.scenarios - 1], 4);

        //load new scene 
        string scene = Player.age + Player.alottedRound[Player.scenarios - 1].id + "E4";
        SceneManager.LoadScene(scene);
    }
}
