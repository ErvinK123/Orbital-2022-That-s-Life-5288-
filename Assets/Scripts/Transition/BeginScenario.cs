using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BeginScenario : MonoBehaviour
{
    public void begin()
    {
        //Debug.Log(Player.childAlotted[0].name);
        Player.prevSceneName = Player.childAlotted[0].name;
        SceneManager.LoadScene(Player.childAlotted[0].name); 
    }
}
