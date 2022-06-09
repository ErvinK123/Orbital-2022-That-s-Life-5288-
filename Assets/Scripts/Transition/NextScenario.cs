using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextScenario : MonoBehaviour
{
    public void next()
    {
        Player.ageUp();
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
