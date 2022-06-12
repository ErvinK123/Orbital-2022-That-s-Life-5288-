using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 

public class elder2frScenario : MonoBehaviour
{
    public static Scenario[] elder2frArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        elder2frScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return elder2frScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        elder2frArr = new Scenario[num];
        string temp = "Elder2fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            elder2frArr[i] = new Scenario(number, temp + number, 3);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = elder2frArr.Clone() as Scenario[];
        for (int i = 0; i < elder2frArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
