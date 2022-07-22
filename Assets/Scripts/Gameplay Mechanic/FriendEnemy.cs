using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;


public class FriendEnemy : MonoBehaviour , IDataPersistance
{
    public static string[] friend1Arr;
    public static string[] friend2Arr; 
    public static string[] enemyArr;

    public static List<string> friend1List;
    public static List<string> friend2List;
    public static List<string> enemyList; 

    public static int friend1Pointer;
    public static int friend2Pointer;
    public static int enemyPointer;

    public static string[] friend1Pool = new string[10] {"Levi", "Evan", "Axel", "Mark", "Owen", "Arlo", "Milo", "Rory", "Remy", "Enzo"};
    public static string[] friend2Pool = new string[10] {"Riley", "Hazel", "Sally", "Grace", "Avery", "Layla", "Alice", "Maria", "Quinn", "Piper"};
    public static string[] enemyPool = new string[10] { "Jax", "Ace", "Tom", "Bob", "Ian", "Jed", "Kai", "Leo", "Ari", "Sky"};

    public static void feSaveSetUp(string[] arr, string status)
    {
        if (status == "friend1")
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                temp.Add(arr[i]);
            }
            friend1List = temp;
        }
        else if (status == "friend2")
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                temp.Add(arr[i]);
            }
            friend2List = temp;
        }
        else 
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                temp.Add(arr[i]);
            }
            enemyList = temp;
        }
    }

    public static void friendWrite(List<string> li, string status)
    {
        if (status == "friend1")
        {
            string[] temp = new string[li.Count];
            for (int i = 0; i < li.Count; i++)
            {
                temp[i] = li[i];
            }
            friend1Arr = temp;
        }
        else if (status == "friend2")
        {
            string[] temp = new string[li.Count];
            for (int i = 0; i < li.Count; i++)
            {
                temp[i] = li[i];
            }
            friend2Arr = temp;
        }
        else
        {
            string[] temp = new string[li.Count];
            for (int i = 0; i < li.Count; i++)
            {
                temp[i] = li[i];
            }
            enemyArr = temp;
        }
    }

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

    public void LoadData(GameData data)
    {
        friend1List = data.friend1List;
        friend2List = data.friend2List;
        enemyList = data.enemyList;

        friend1Pointer = data.friend1Pointer;
        friend2Pointer = data.friend2Pointer;
        enemyPointer = data.enemyPointer; 
    }

    public void SaveData(ref GameData data)
    {
        data.friend1List = friend1List;
        data.friend2List = friend2List;
        data.enemyList = enemyList;

        data.friend1Pointer = friend1Pointer;
        data.friend2Pointer = friend2Pointer;
        data.enemyPointer = enemyPointer;
    }

    public static void initializeFEPool()
    {
        friend1Arr = randomizeArray(friend1Pool);
        friend2Arr = randomizeArray(friend2Pool);
        enemyArr = randomizeArray(enemyPool);
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
