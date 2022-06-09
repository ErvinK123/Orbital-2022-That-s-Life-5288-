using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class adult1frScenario : MonoBehaviour
{
    public static Scenario[] adult1frArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        adult1frScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return adult1frScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        adult1frArr = new Scenario[num];
        string temp = "Adult1fr";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            adult1frArr[i] = new Scenario(number, temp + number);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = adult1frArr.Clone() as Scenario[];
        for (int i = 0; i < adult1frArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
