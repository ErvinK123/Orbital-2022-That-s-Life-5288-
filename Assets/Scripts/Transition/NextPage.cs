using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class NextPage : MonoBehaviour
{
    //number of scenarios per phase of life
    // can be randomized 
    public static int numberOfScene = 5;

    // Initialising the Fair and Random buttons as game objects
    public GameObject FairButton;
    public GameObject RandomButton;
    
    // Initialising an array for storing the fair introductions
    public string[] fairIntros = { "StandardIntro1", "StandardIntro2", "StandardIntro3" };

    // Function to randomize an array of string
    public string[] randomize(string[] fairIntros)
    {
        string[] newArray = fairIntros.Clone() as string[];
        for (int i = 0; i < fairIntros.Length; i++)
        {
            string tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
    
    public void next()
    {
        if (Player.name == null || Player.name == "") 
        {
            Player.nameReset();
            SceneManager.LoadScene("NameErrorEmpty");
        } else if (Player.name.Length > 10)
        {
            Player.nameReset(); 
            SceneManager.LoadScene("NameErrorLong");
            
        } else
        {
            if (!FairButton.activeSelf) // Fair option is selected
            {
                string[] randomFairIntros = randomize(fairIntros);
                SceneManager.LoadScene(randomFairIntros[0]);
            } else // Random option is selected
            {
                SceneManager.LoadScene(Player.useIntro());
            }
        }
    } 

    public void back()
    {
        SceneManager.LoadScene("StartPage");
    }

    void Start()
    {
        //sizes of each pool
        int childScene = 10;

        int teenScene = 6;
        int teen1fr1Scene = 1;
        int teen1fr2Scene = 1;
        int teen2frScene = 2;
        int teen1enScene = 2;

        int adultScene = 10;
        int adult1fr1Scene = 1;
        int adult1fr2Scene = 1; 
        int adult2frScene = 2;
        int adult1enScene = 2;

        int elderlyScene = 10;
        int elderly1fr1Scene = 1;
        int elderly1fr2Scene = 1; 
        int elderly2frScene = 2;
        int elderly1enScene = 2;

        int fLimit = 2;
        int enLimit = 1;
        Player.setFElimits(fLimit, enLimit);
        Player.setUpScenarios(childScene, teenScene, teen1fr1Scene, teen1fr2Scene, teen2frScene, teen1enScene, 
            adultScene, adult1fr1Scene, adult1fr2Scene,adult2frScene, adult1enScene,
            elderlyScene, elderly1fr1Scene, elderly1fr2Scene, elderly2frScene, elderly1enScene);
        Player.allocateScenarios(Player.randomizeArray(childScenario.childArr), "Child");
        Player.allocateScenarios(Player.generateArray(teenScenario.teenArr, teen1fr1Scenario.teen1fr1Arr, teen1fr2Scenario.teen1fr2Arr, teen2frScenario.teen2frArr, teen1enScenario.teen1enArr), "Teen");
        Player.allocateScenarios(Player.generateArray(adultScenario.adultArr, adult1fr1Scenario.adult1fr1Arr, adult1fr2Scenario.adult1fr2Arr, adult2frScenario.adult2frArr, adult1enScenario.adult1enArr), "Adult");
        Player.allocateScenarios(Player.generateArray(elderScenario.elderArr, elder1fr1Scenario.elder1fr1Arr, elder1fr2Scenario.elder1fr2Arr, elder2frScenario.elder2frArr, elder1enScenario.elder1enArr), "Elder");
        FriendEnemy.initializeFEPool();
        Player.initializeChoices(); 
    }
}

