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
            Debug.Log(Player.scenarios);
            string scene = Player.getNextScenarioName();
            Player.prevSceneName = scene;
            Debug.Log(scene);
            SceneManager.LoadScene(scene);
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }
}
