using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class elderScenario : MonoBehaviour
{
    public static Scenario[] elderArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        elderScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return elderScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        elderArr = new Scenario[num];
        string temp = "Elder";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            elderArr[i] = new Scenario(number, temp + number, 1);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = elderArr.Clone() as Scenario[];
        for (int i = 0; i < elderArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;

    }
}
