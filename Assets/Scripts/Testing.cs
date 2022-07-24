using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void testScenario()
    {
        int childScene = 12;

        int teenScene = 12;
        int teen1fr1Scene = 2;
        int teen1fr2Scene = 2;
        int teen2frScene = 2;
        int teen1enScene = 2;

        int adultScene = 12;
        int adult1fr1Scene = 2;
        int adult1fr2Scene = 2;
        int adult2frScene = 2;
        int adult1enScene = 2;

        int elderlyScene = 12;
        int elderly1fr1Scene = 2;
        int elderly1fr2Scene = 2;
        int elderly2frScene = 2;
        int elderly1enScene = 2;

        Player.setUpScenarios(childScene, teenScene, teen1fr1Scene, teen1fr2Scene, teen2frScene, teen1enScene,
    adultScene, adult1fr1Scene, adult1fr2Scene, adult2frScene, adult1enScene,
    elderlyScene, elderly1fr1Scene, elderly1fr2Scene, elderly2frScene, elderly1enScene);
        Player.allocateScenarios(Player.randomizeArray(childScenario.childArr), "Child");
        Player.allocateScenarios(Player.generateArray(teenScenario.teenArr, teen1fr1Scenario.teen1fr1Arr, teen1fr2Scenario.teen1fr2Arr, teen2frScenario.teen2frArr, teen1enScenario.teen1enArr), "Teen");
        Player.allocateScenarios(Player.generateArray(adultScenario.adultArr, adult1fr1Scenario.adult1fr1Arr, adult1fr2Scenario.adult1fr2Arr, adult2frScenario.adult2frArr, adult1enScenario.adult1enArr), "Adult");
        Player.allocateScenarios(Player.generateArray(elderScenario.elderArr, elder1fr1Scenario.elder1fr1Arr, elder1fr2Scenario.elder1fr2Arr, elder2frScenario.elder2frArr, elder1enScenario.elder1enArr), "Elder");


        Scenario[] childAlotted = Player.childAlotted;
        Scenario[] teenAlotted = Player.teenAlotted;
        Scenario[] adultAlotted = Player.adultAlotted;
        Scenario[] elderAlotted = Player.elderAlotted;

        Debug.Log("ChildScenarios");
        for (int i = 0; i < childAlotted.Length; i++)
        {
            Debug.Log(childAlotted[i].name); 
        }

        Debug.Log("TeenScenarios"); 
        for (int i = 0; i < teenAlotted.Length; i++)
        {
            Debug.Log(teenAlotted[i].name);
        }

        Debug.Log("AdultScenarios");
        for (int i = 0; i < adultAlotted.Length; i++)
        {
            Debug.Log(adultAlotted[i].name);
        }

        Debug.Log("ElderScenarios");
        for (int i = 0; i < elderAlotted.Length; i++)
        {
            Debug.Log(elderAlotted[i].name);
        }

    }
}
