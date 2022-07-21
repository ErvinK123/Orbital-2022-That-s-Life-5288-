using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BackToMain : MonoBehaviour
{
    public void back()
    {
        Player.currScene = null;
        DataPersistanceManager.instance.SaveGame();
        SceneManager.LoadScene("StartPage");
    }
}

