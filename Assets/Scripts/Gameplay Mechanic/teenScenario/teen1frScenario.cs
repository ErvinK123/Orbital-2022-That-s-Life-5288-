using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class teen1frScenario : MonoBehaviour
{
    public static Scenario[] teen1frArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        teen1frScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return teen1frScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        teen1frArr = new Scenario[num];
        string temp = "Teen1fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            teen1frArr[i] = new Scenario(number, temp + number, 2);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = teen1frArr.Clone() as Scenario[];
        for (int i = 0; i < teen1frArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
}
