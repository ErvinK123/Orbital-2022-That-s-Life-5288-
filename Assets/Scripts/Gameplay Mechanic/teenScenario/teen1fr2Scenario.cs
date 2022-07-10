using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teen1fr2Scenario : MonoBehaviour
{
    public static Scenario[] teen1fr2Arr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        teen1fr2Scenario.numScene = i;
    }

    public static int getNumScene()
    {
        return teen1fr2Scenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        teen1fr2Arr = new Scenario[num];
        string temp = "Teen12fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            teen1fr2Arr[i] = new Scenario(number, temp + number, 6);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = teen1fr2Arr.Clone() as Scenario[];
        for (int i = 0; i < teen1fr2Arr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
}
