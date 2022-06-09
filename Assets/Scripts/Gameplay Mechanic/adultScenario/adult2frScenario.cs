using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 

public class adult2frScenario : MonoBehaviour
{
    public static Scenario[] adult2frArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        adult2frScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return adult2frScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        adult2frArr = new Scenario[num];
        string temp = "Adult2fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            adult2frArr[i] = new Scenario(number, temp + number);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = adult2frArr.Clone() as Scenario[];
        for (int i = 0; i < adult2frArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
