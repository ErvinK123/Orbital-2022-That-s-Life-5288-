using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BeginScenario : MonoBehaviour
{
    public void begin()
    {
        SceneManager.LoadScene("Scenario1"); 
    }
}
