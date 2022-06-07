using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerGenerator : MonoBehaviour
{
    // Initialising the Fair and Random buttons as game objects
    public GameObject FairButton;
    public GameObject RandomButton;

    
    void Start()
    {
        // Default to generating fair stats for the player
        Player.generateFair();

        // Shows Fair as ticked while allowing player to click the Random button
        FairButton.SetActive(false);
        RandomButton.SetActive(true);
    }

    // Function to call when Fair button is clicked
    public void generateFair()
    {
        Player.generateFair();
        FairButton.SetActive(false);
        RandomButton.SetActive(true);
    }

    // Function to call when Random button is clicked
    public void generateRandom()
    {
        Player.generateRandom();
        FairButton.SetActive(true);
        RandomButton.SetActive(false);
    }
}
