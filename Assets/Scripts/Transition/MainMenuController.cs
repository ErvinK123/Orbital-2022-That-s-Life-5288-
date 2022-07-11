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


    private void Start()
    {
        if (!DataPersistanceManager.instance.HasGameData())
        {
            loadGameButton.interactable = false;
        }
    }

    public void playGame()
    {
        Player.reset();
        DataPersistanceManager.instance.NewGame();
        SceneManager.LoadScene("NamePage"); 
    }

    public void loadGame()
    {
        //TODO: 
        DataPersistanceManager.instance.LoadGame();
        SceneManager.LoadScene(Player.currScene);
    }

    public void achievementsPage()
    {
        //DataPersistanceManager.instance.LoadGame();
        SceneManager.LoadScene("AchievementPage1");
    }

    public void settings()
    {
        SceneManager.LoadScene("SettingsPage");
    }
}
