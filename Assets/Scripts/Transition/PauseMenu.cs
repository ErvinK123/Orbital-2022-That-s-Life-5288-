using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Initialising the Game Objects as variables
    public GameObject PopupMenu;
    public GameObject SavedIndicator;
    public GameObject MainMenuConfirmation;

    void Start()
    {
        PopupMenu.SetActive(false);
        SavedIndicator.SetActive(false);
        MainMenuConfirmation.SetActive(false);
    }

    // Opening the pause menu
    public void open()
    {
        PopupMenu.SetActive(true);
    }

    // Closing the pause menu
    public void close()
    {
        PopupMenu.SetActive(false);
    }

    // Going to Main Menu
    public void MainMenu()
    {
        MainMenuConfirmation.SetActive(true);
    }

    // Save the game and bring to Main Menu
    public void MainMenuSave()
    {
        // insert save functionality here

        SceneManager.LoadScene("StartPage");
    }

    public void MainMenuNoSave()
    {
        SceneManager.LoadScene("StartPage");
    }

    // Pressing the save button
    public void save()
    {
        // insert save functionality here
        
        DataPersistanceManager.instance.SaveGame();
        SavedIndicator.SetActive(true);
    }

    // Close the Saved Indicator Page
    public void closeSavedIndicator()
    {
        SavedIndicator.SetActive(false);
    }

}
