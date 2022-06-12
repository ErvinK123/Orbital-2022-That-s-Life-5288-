using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class teen2frScenario : MonoBehaviour
{
    public static Scenario[] teen2frArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        teen2frScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return teen2frScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        teen2frArr = new Scenario[num];
        string temp = "Teen2fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            teen2frArr[i] = new Scenario(number, temp + number, 3);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = teen2frArr.Clone() as Scenario[];
        for (int i = 0; i < teen2frArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
}
