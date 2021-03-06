using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class adult1enScenario : MonoBehaviour
{
    public static Scenario[] adult1enArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        adult1enScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return adult1enScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        adult1enArr = new Scenario[num];
        string temp = "Adult1en";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            adult1enArr[i] = new Scenario(number, temp + number, 4);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = adult1enArr.Clone() as Scenario[];
        for (int i = 0; i < adult1enArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
