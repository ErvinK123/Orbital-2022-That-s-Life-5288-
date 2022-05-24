using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndtoSummary : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("Summary"); 
    }
}
