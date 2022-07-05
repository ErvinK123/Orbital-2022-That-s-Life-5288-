using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextScenario : MonoBehaviour
{
    public void next()
    {
        if (Player.feTrigger() && Player.age != "Dead")
        {
            string next = Player.generateFEscreen();
            Player.offFEtriggers();
            Player.currScene = next;
            SceneManager.LoadScene(next);
            return;
        }

        if (Player.transitionTrigger() && Player.age != "Dead")
        {
            string next = Player.generateTransition();
            Player.currScene = next;
            SceneManager.LoadScene(next);
            return;
        }

        Player.ageUp();
        Player.setTransition();

        if (Player.age != "Dead")
        {   
            string scene = Player.getNextScenarioName(Player.age);
            //Debug.Log(scene);
            Player.prevSceneName = scene;
            Player.increasePointer(Player.age);
            Player.currScene = scene;
            SceneManager.LoadScene(scene);
        }
        else
        {
            Player.currScene = "End";
            SceneManager.LoadScene("End");
        }
    }

    public void endGame()
    {
        SceneManager.LoadScene("End");
    }
}
