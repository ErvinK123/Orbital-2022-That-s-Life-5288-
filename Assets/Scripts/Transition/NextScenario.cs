using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextScenario : MonoBehaviour
{
    public Animator SceneTransition;

    IEnumerator LoadFE()
    {
        string next = Player.generateFEscreen();
        Player.offFEtriggers();
        Player.currScene = next;
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(next);
    }

    IEnumerator LoadNextTransition()
    {
        string next = Player.generateTransition();
        Player.currScene = next;
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(next);
    }

    IEnumerator LoadNextScene()
    {
        string scene = Player.getNextScenarioName(Player.age);
        Player.prevSceneName = scene;
        Player.increasePointer(Player.age);
        Player.currScene = scene;
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(scene);
    }

    IEnumerator LoadEnd()
    {
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("End");
    }



    public void next()
    {

        if (Player.feTrigger() && Player.age != "Dead")
        {
            StartCoroutine("LoadFE");
            return;
        }

        if (Player.transitionTrigger() && Player.age != "Dead")
        {
            StartCoroutine("LoadNextTransition");
            return;
        }

        Player.ageUp();
        Player.setTransition();

        if (Player.age != "Dead")
        {
            StartCoroutine("LoadNextScene");
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
