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
            string scene = Player.alottedRound[Player.scenarios - 1].name;
            SceneManager.LoadScene(scene);
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }
}
