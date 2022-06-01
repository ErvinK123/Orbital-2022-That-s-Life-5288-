using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuController : MonoBehaviour
{
    public void playGame()
    {
        Player.reset(); 
        SceneManager.LoadScene("NamePage"); 
    }

    public void loadGame()
    {
        //TODO: 
    }

    public void achievementsPage()
    {
        SceneManager.LoadScene("AchievementPage1");
    }

    public void  settings()
    {
        //TODO: 
    }
}
