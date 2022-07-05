using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextScenario : MonoBehaviour
{
    public void next()
    {
        //Debug.Log(FriendEnemy.friend1Pointer);
        Player.testFE();
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
            string scene = Player.getNextScenarioName(Player.age);
            //Debug.Log(scene);
            Player.prevSceneName = scene;
            Player.increasePointer(Player.age);
            SceneManager.LoadScene(scene);
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }
}
