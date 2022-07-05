using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;


public class FriendEnemy : MonoBehaviour
{
    public static string[] friend1Arr;
    public static string[] friend2Arr; 
    public static string[] enemyArr;

    public static int friend1Pointer;
    public static int friend2Pointer;
    public static int enemyPointer;

    private static string[] friend1Pool = new string[5] {"Levi", "Evan", "Axel", "Mark", "Owen"};
    private static string[] friend2Pool = new string[5] {"Riley", "Hazel", "Sally", "Grace", "Avery"};
    private static string[] enemyPool = new string[5] { "Jax", "Ace", "Tom", "Bob", "Ian" };


    public static string[] randomizeArray(string[] arr1)
    {
        string[] newArray = arr1.Clone() as string[];
        for (int i = 0; i < arr1.Length; i++)
        {
            string tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    public static void initializeFEPool()
    {
        friend1Arr = randomizeArray(friend1Pool);
        friend2Arr = randomizeArray(friend2Pool);
        enemyArr = randomizeArray(enemyPool);

        friend1Pointer = 0;
        friend2Pointer = 0;
        enemyPointer = 0; 
    } 

    public static void increasePointer(int i)
    {
        if (i == 1)
        {
            friend1Pointer++;
        } else if (i == 2)
        {
            friend2Pointer++; 
        } else
        {
            enemyPointer++;
        }
    }
}
