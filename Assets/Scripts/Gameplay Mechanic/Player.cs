using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Choice
{
    public Scenario scenario;
    public int choice; 

    public Choice(Scenario s, int c)
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

    public static Scenario[] alottedRound; 
    
    public static void ageUp()
    {
        Player.scenarios += 1;

        if (Player.scenarios <= 2)
        {
            Player.age = "Child";
        } else if (Player.scenarios <= 4) {
            Player.age = "Teen"; 
        } else if (Player.scenarios <= 6)
        {
            Player.age = "Adult";
        } else if (Player.scenarios <= 8) 
        {
            Player.age = "Elder";
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
                if (i < 2)
                {
                    Player.calculateHelper(ChoiceValues.childResult, i, j);
                } else if (i < 4)
                {
                    Player.calculateHelper(ChoiceValues.teenResult, i, j);
                } else if (i < 6)
                {
                    Player.calculateHelper(ChoiceValues.adultResult, i, j);
                } else
                {
                    Player.calculateHelper(ChoiceValues.elderResult, i, j);
                }
            }
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
                Player.title = "Social Butterfly"; 
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
                Player.title = "Zombie";
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

    public static void calculateHelper(int[,,] currArr, int first, int second) 
    {
        if (second == 0)
        {
            
            Player.Career += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
        }
        else if (second == 1)
        {
            Player.Popularity += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
        }
        else if (second == 2)
        {
            Player.Health += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
        }
        else if (second == 3)
        {
            Player.LifeSkills += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
        }
        else
        {
            Player.Morals += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
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

    public static void setUpScenarios(int num)
    {
        childScenario.generateScenarios(num);
        teenScenario.generateScenarios(num);
        adultScenario.generateScenarios(num);
        elderScenario.generateScenarios(num);

        childScenario.gameArr = childScenario.randomizeArray();
        teenScenario.gameArr = teenScenario.randomizeArray();
        adultScenario.gameArr = adultScenario.randomizeArray();
        elderScenario.gameArr = elderScenario.randomizeArray();

    }

    public static void allocateScenarios()
    {
        int num = NextPage.numberOfScene;
        int total = 4 * num;

        Scenario[] temp = new Scenario[total]; 

        for (int k = 0; k < total; k++)
        {
            if (k < num)
            {
                temp[k] = childScenario.gameArr[k];
            }
            else if (k < 2 * num)
            {
                temp[k] = teenScenario.gameArr[k - num]; 
            } else if ( k < 3 * num)
            {
                temp[k] = adultScenario.gameArr[k - (2 * num)]; 
            } else
            {
                temp[k] = elderScenario.gameArr[k - (3 * num)]; 
            }

        }
        Player.alottedRound = temp;

        return;
    } 
}
