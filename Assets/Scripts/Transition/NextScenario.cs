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
            SceneManager.LoadScene(next);
            return;
        }

        if (Player.transitionTrigger() && Player.age != "Dead")
        {
            string next = Player.generateTransition();
            SceneManager.LoadScene(next);
            return;
        }

        Player.ageUp();
        Player.setTransition();

        if (Player.age != "Dead")
        {   
            string scene = Player.getNextScenarioName();
            Player.prevSceneName = scene;
            SceneManager.LoadScene(scene);
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }
}
