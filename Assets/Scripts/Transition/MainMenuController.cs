using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button loadGameButton;
    [SerializeField] private Button achievements;
    [SerializeField] private Button settingsButton;

    public Animator SceneTransition;

    IEnumerator LoadStart()
    {
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("NamePage");
    }

    IEnumerator LoadGame()
    {
        SceneTransition.SetTrigger("Start");
        DataPersistanceManager.instance.LoadGame();

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(Player.currScene);
    }

    IEnumerator LoadAchievement()
    {
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("AchievementPage1");
    }

    IEnumerator LoadSettings()
    {
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("SettingsPage");
    }



    private void Update()
    {
        if (!DataPersistanceManager.instance.HasGameData() || Player.currScene == null || Player.currScene == "")
        {
            loadGameButton.interactable = false;
        }

        //Player.showBadgeFirstTime();
    }

    public void playGame()
    {
        Player.reset();
        DataPersistanceManager.instance.NewGame();
        
        StartCoroutine("LoadStart");
    }

    public void loadGame()
    {

        StartCoroutine("LoadGame");
    }

    public void achievementsPage()
    {

        StartCoroutine("LoadAchievement");
    }

    public void settings()
    {
        StartCoroutine("LoadSettings");
    }

}
