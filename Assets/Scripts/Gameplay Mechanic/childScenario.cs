using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 

public struct Scenario
{
    public int id;
    public string name; 

    public Scenario (int id, string name)
    {
        this.id = id;
        this.name = name; 
    }
}

public class childScenario : MonoBehaviour
{
    public static Scenario[] childArr;

    public static Scenario[] gameArr; 

    public static void generateScenarios(int num)
    {
        childArr = new Scenario[num];
        string temp = "Child"; 
        
        for(int i = 0; i < num; i++)
        {
            int number = i + 1;
            childArr[i] = new Scenario(number, temp + number);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = childArr.Clone() as Scenario[]; 
        for(int i = 0; i < childArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp; 
        }
        return newArray; 
        
    }
}
