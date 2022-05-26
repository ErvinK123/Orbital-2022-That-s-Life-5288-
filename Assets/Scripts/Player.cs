using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Choice
{
    public int scenario;
    public int choice; 

    public Choice(int s, int c)
    {
        scenario = s;
        choice = c; 
    }
}

public class Player : MonoBehaviour
{   
    public static string name;
    public static string age = "Child";

    public static int scenarios = 1;

    public static Choice[] choiceArr = new Choice[8];

    public static int Career = 50;
    public static int Popularity = 50;
    public static int Health = 50;
    public static int LifeSkills = 50;
    public static int Morals = 50; 
    
    public static void ageUp()
    {
        Player.scenarios += 1;

        if (Player.scenarios <= 2)
        {
            Player.age = "Child";
        } else if (Player.scenarios <= 4) {
            Player.age = "Teenager"; 
        } else if (Player.scenarios <= 6)
        {
            Player.age = "Adult";
        } else if (Player.scenarios <= 8) 
        {
            Player.age = "Elderly";
        } else
        {
            Player.age = "Dead"; 
        }
    }

    public static void reset()
    {
        Player.age = "Child";
        Player.Career = 50;
        Player.Popularity = 50;
        Player.Health = 50;
        Player.LifeSkills = 50;
        Player.Morals = 50;
        Player.scenarios = 1;

        Player.choiceArr = new Choice[8]; 
    }

    public static void calculate()
    {
        for (int i=0; i < 8; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == 0)
                {
                    Player.Career += ChoiceValues.arr[i, choiceArr[i].choice - 1, j];
                } else if (j == 1)
                {
                    Player.Popularity += ChoiceValues.arr[i, choiceArr[i].choice - 1, j];
                } else if (j == 2)
                {
                    Player.Health += ChoiceValues.arr[i, choiceArr[i].choice - 1, j];
                } else if (j == 3)
                {
                    Player.LifeSkills += ChoiceValues.arr[i, choiceArr[i].choice - 1, j];
                } else
                {
                    Player.Morals += ChoiceValues.arr[i, choiceArr[i].choice - 1, j];
                }
            }
        }
    }
}
