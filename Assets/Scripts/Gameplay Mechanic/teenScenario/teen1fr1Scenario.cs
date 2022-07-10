using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class teen1fr1Scenario : MonoBehaviour
{
    public static Scenario[] teen1fr1Arr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        teen1fr1Scenario.numScene = i;
    }

    public static int getNumScene()
    {
        return teen1fr1Scenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        teen1fr1Arr = new Scenario[num];
        string temp = "Teen11fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            teen1fr1Arr[i] = new Scenario(number, temp + number, 2);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = teen1fr1Arr.Clone() as Scenario[];
        for (int i = 0; i < teen1fr1Arr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
}
