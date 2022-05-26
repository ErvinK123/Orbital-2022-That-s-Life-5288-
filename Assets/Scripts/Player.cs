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
    public static string title = "Jack Of All Trades";

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
        Player.name = "";

        Player.choiceArr = new Choice[8]; 
    }

    public static void nameReset()
    {
        Player.name = ""; 
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
            int temp = i + 1;
            string de = "Scenario " + temp + ": " + ChoiceValues.arr[i, choiceArr[i].choice - 1, 0]
                         + ChoiceValues.arr[i, choiceArr[i].choice - 1, 1]
                         + ChoiceValues.arr[i, choiceArr[i].choice - 1, 2]
                         + ChoiceValues.arr[i, choiceArr[i].choice - 1, 3]
                         + ChoiceValues.arr[i, choiceArr[i].choice - 1, 4];
            Debug.Log(de);
        }

        
        int[] tempArr = new int[] { Player.Career, Player.Popularity, Player.Health, Player.LifeSkills, Player.Morals };
        string best = "Career";
        string worst = "Career";
        int highestvalue = Player.Career;
        int lowestvalue = Player.Career;

        for (int r = 1; r < 5; r++)
        {
            if (tempArr[r]> highestvalue)
            {
                highestvalue = tempArr[r];
                best = Player.getattributeName(r); 
            } else if (tempArr[r] < lowestvalue)
            {
                lowestvalue = tempArr[r];
                worst = Player.getattributeName(r); 
            }
        }

        Player.title = "Jack Of All Trades"; 

        if (highestvalue > 70)
        {
            if (best == "Career")
            {
                Player.title = "Work Junkie";
            } else if (best == "Popularity") 
            {
                Player.title = "Smooth Brain"; 
            } else if (best == "Health")
            {
                Player.title = "Peak Human";
            } else if (best == "LifeSKills") 
            {
                Player.title = "Handyman";
            } else
            {
                Player.title = "Saint"; 
            }
            
        }

        if (lowestvalue < 40)
        {
            if (worst == "Career")
            {
                Player.title = "Smooth Brain";
            }
            else if (worst == "Popularity")
            {
                Player.title = "Shut-In";
            }
            else if (worst == "Health")
            {
                Player.title = "Zomebie";
            }
            else if (worst == "LifeSkills")
            {
                Player.title = "Hopelessly Inept";
            }
            else
            {
                Player.title = "Villain";
            }

        }


    }
    
    //work junkie/smooth brain 
    //social butterfly/ shut-in
    //peak human / zombie
    //handyman / hopelessly inept
    //saint / villain 
    // jack of all trades/ master of none 

    public static string getattributeName(int id)
    {
        if (id == 0)
        {
            return "Career";
        }
        else if (id == 1)
        {
            return "Popularity";
        }
        else if (id == 2)
        {
            return "Health";
        }
        else if (id == 3)
        {
            return "LifeSkills";
        } else
        {
            return "Morals";
        }
    }
}
