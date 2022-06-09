using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class elder1enScenario : MonoBehaviour
{
    public static Scenario[] elder1enArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        elder1enScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return elder1enScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        elder1enArr = new Scenario[num];
        string temp = "Elder1en";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            elder1enArr[i] = new Scenario(number, temp + number);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = elder1enArr.Clone() as Scenario[];
        for (int i = 0; i < elder1enArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
