using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextScenario : MonoBehaviour
{

   
    public void choice1()
    {
        //store choice 
        Player.choiceArr[Player.scenarios -1] = new Choice(Player.scenarios, 1); 

        //load new scene 
        Player.ageUp();
        if (Player.age != "Dead")
        {
            string scene = "Scenario" + Player.scenarios;
            SceneManager.LoadScene(scene);
        }
        else
        {
            SceneManager.LoadScene("End");
        }

     }


    public void choice2()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.scenarios, 2);

        //load new scene 
        Player.ageUp();
        if (Player.age != "Dead")
        {
            string scene = "Scenario" + Player.scenarios;
            SceneManager.LoadScene(scene);
        } else
        {
            SceneManager.LoadScene("End");
        }
    }

    public void choice3()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.scenarios, 3);

        //load new scene 
        Player.ageUp();
        if (Player.age != "Dead")
        {
            string scene = "Scenario" + Player.scenarios;
            SceneManager.LoadScene(scene);
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }

    public void choice4()
    {
        //store choice 
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.scenarios, 4);

        //load new scene 
        Player.ageUp();
        if (Player.age != "Dead")
        {
            string scene = "Scenario" + Player.scenarios;
            SceneManager.LoadScene(scene);
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }
}
