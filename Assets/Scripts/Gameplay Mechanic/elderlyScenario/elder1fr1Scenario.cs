using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elder1fr1Scenario : MonoBehaviour
{
    public static Scenario[] elder1fr1Arr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        elder1fr1Scenario.numScene = i;
    }

    public static int getNumScene()
    {
        return elder1fr1Scenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        elder1fr1Arr = new Scenario[num];
        string temp = "Elder11fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            elder1fr1Arr[i] = new Scenario(number, temp + number, 2);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = elder1fr1Arr.Clone() as Scenario[];
        for (int i = 0; i < elder1fr1Arr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
