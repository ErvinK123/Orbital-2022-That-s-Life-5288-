using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextPage : MonoBehaviour
{
    public void next()
    {   
        SceneManager.LoadScene("Introduction");
    }
}

