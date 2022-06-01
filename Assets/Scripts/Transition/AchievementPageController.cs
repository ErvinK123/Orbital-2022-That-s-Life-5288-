using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievementPageController : MonoBehaviour
{
    public void startPage()
    {
        SceneManager.LoadScene("StartPage");
    }

    public void nextPage()
    {
        SceneManager.LoadScene("AchievementPage2");
    }

    public void previousPage()
    {
        SceneManager.LoadScene("AchievementPage1");
    }
}