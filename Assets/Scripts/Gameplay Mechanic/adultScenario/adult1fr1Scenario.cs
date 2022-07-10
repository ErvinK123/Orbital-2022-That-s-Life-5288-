using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adult1fr1Scenario : MonoBehaviour
{
    public static Scenario[] adult1fr1Arr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        adult1fr1Scenario.numScene = i;
    }

    public static int getNumScene()
    {
        return adult1fr1Scenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        adult1fr1Arr = new Scenario[num];
        string temp = "Adult11fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            adult1fr1Arr[i] = new Scenario(number, temp + number, 2);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = adult1fr1Arr.Clone() as Scenario[];
        for (int i = 0; i < adult1fr1Arr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
