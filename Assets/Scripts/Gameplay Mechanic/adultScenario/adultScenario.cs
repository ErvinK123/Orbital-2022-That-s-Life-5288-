using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 


public class adultScenario : MonoBehaviour
{
    public static Scenario[] adultArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        adultScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return adultScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        adultArr = new Scenario[num];
        string temp = "Adult";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            adultArr[i] = new Scenario(number, temp + number, 1);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = adultArr.Clone() as Scenario[];
        for (int i = 0; i < adultArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
