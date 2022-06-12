using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 


public class teenScenario : MonoBehaviour
{
    public static Scenario[] teenArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        teenScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return teenScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        teenArr = new Scenario[num];
        string temp = "Teen";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            teenArr[i] = new Scenario(number, temp + number, 1);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = teenArr.Clone() as Scenario[];
        for (int i = 0; i < teenArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
