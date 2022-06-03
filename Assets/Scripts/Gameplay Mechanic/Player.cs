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
    public static string title;

    // Initialising the achievement badge trackers;
    public static bool WorkJunkieGet = false;
    public static bool SmoothBrainGet = false;
    public static bool SocialButterflyGet = false;
    public static bool ShutInGet = false;
    public static bool PeakHumanGet = false;
    public static bool ZombieGet = false;
    public static bool HandymanGet = false;
    public static bool HopelesslyIneptGet = false;
    public static bool SaintGet = false;
    public static bool VillainGet = false;
    public static bool JackOfAllTradesGet = false;
    public static bool MasterOfNoneGet = false;
    public static bool CollectorGet = false;

    public static int scenarios = 1;

    public static Choice[] choiceArr = new Choice[8];

    public static int Career = 50;
    public static int Popularity = 50;
    public static int Health = 50;
    public static int LifeSkills = 50;
    public static int Morals = 50;

    public static Scenario[] alottedRound;

    //Used when there is a invalid name input
    public static void nameReset()
    {
        Player.name = "";
    }

    // Fills in the Scenarios array in each Scenario class and randomizes them
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

    // generates an array of scenario for the player for that run 
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
            }
            else if (k < 3 * num)
            {
                temp[k] = adultScenario.gameArr[k - (2 * num)];
            }
            else
            {
                temp[k] = elderScenario.gameArr[k - (3 * num)];
            }

        }
        Player.alottedRound = temp;

        return;
    }

    //Store choice given number of button pressed
    public static void storeChoice(int i)
    {
        Player.choiceArr[Player.scenarios - 1] = new Choice(Player.alottedRound[Player.scenarios - 1], i);
        return; 
    }

    public static string getNextSceneName(int j)
    {
        if (j == 1)
        {
            return Player.age + Player.alottedRound[Player.scenarios - 1].id + "E1";       
        } else if (j == 2)
        {
            return Player.age + Player.alottedRound[Player.scenarios - 1].id + "E2";
        } else if (j == 3)
        {
            return Player.age + Player.alottedRound[Player.scenarios - 1].id + "E3";
        } else
        {
            return Player.age + Player.alottedRound[Player.scenarios - 1].id + "E4";
        }
    }

    //Happens on next scenario in void Start()
    public static void ageUp()
    {
        Player.scenarios += 1;

        if (Player.scenarios <= 2)
        {
            Player.age = "Child";
            return; 
        } else if (Player.scenarios <= 4) {
            Player.age = "Teen";
            return;
        } else if (Player.scenarios <= 6)
        {
            Player.age = "Adult";
            return;
        } else if (Player.scenarios <= 8) 
        {
            Player.age = "Elder";
            return; 
        } else
        {
            Player.age = "Dead";
            return;
        }
    }

    //Reset all after a run 
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
        return; 
    }


    //Happens at the  end of a run, determines the title and the attributes of the player
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

        Player.title = "Master Of None";

        foreach(int i in tempArr)
        {
            if (i > 60 || i < 40)
            {
                Player.title = "Jack Of All Trades";
            }
        }

        if (highestvalue > 70)
        {
            Player.getBadgeBest(best);
            return;
        }

        if (lowestvalue < 40)
        {
            Player.getBadgeWorst(worst);
            return; 
        }

        Player.getBadgeNeutral(Player.title);
    }   
        
    // Used in calculate : Title and badge 
    public static void getBadgeBest(string b)
    {
        if (b == "Career")
        {
            Player.title = "Work Junkie";
            Player.WorkJunkieGet = true;
            return;
        }
        else if (b == "Popularity")
        {
            Player.title = "Social Butterfly";
            Player.SocialButterflyGet = true;
            return;
        }
        else if (b == "Health")
        {
            Player.title = "Peak Human";
            Player.PeakHumanGet = true;
            return;
        }
        else if (b == "LifeSkills")
        {
            Player.title = "Handyman";
            Player.HandymanGet = true;
            return;
        }
        else
        {
            Player.title = "Saint";
            Player.SaintGet = true;
            return;
        }
    }

    // Used in calculate : Title and badge 
    public static void getBadgeWorst(string w)
    {
        if (w == "Career")
        {
            Player.title = "Smooth Brain";
            Player.SmoothBrainGet = true;
            return;
        }
        else if (w == "Popularity")
        {
            Player.title = "Shut-In";
            Player.ShutInGet = true;
            return;
        }
        else if (w == "Health")
        {
            Player.title = "Zombie";
            Player.ZombieGet = true;
            return;
        }
        else if (w == "LifeSkills")
        {
            Player.title = "Hopelessly Inept";
            Player.HopelesslyIneptGet = true;
            return;
        }
        else
        {
            Player.title = "Villain";
            Player.VillainGet = true;
            return;
        }
    }

    // Used in calculate : Title and badge 
    public static void getBadgeNeutral(string n)
    {
        if (n == "Jack Of All Trades")
        {
            Player.title = "Jack of All Trades";
            Player.JackOfAllTradesGet = true;
            return;
        }
        else if (n == "Master Of None")
        {
            Player.title = "Master Of None";
            Player.MasterOfNoneGet = true;
            return;
        }
    }

    // Used in calculate : Cross checks the choices made by player and changes player attribute 
    public static void calculateHelper(int[,,] currArr, int first, int second) 
    {
        if (second == 0)
        {
            
            Player.Career += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
            return;
        }
        else if (second == 1)
        {
            Player.Popularity += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
            return;
        }
        else if (second == 2)
        {
            Player.Health += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
            return;
        }
        else if (second == 3)
        {
            Player.LifeSkills += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
            return;
        }
        else
        {
            Player.Morals += currArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
            return;
        }
    }
    
    // Used in calculate : returns attribute name given a int parameter  
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
 

    // Used to check if collector badge should be allocated
    public static bool collector()
    {
        if (Player.WorkJunkieGet 
            && Player.SmoothBrainGet 
            && Player.SocialButterflyGet 
            && Player.ShutInGet 
            && Player.PeakHumanGet
            && Player.ZombieGet 
            && Player.HandymanGet 
            && Player.HopelesslyIneptGet 
            && Player.SaintGet 
            && Player.VillainGet
            && Player.JackOfAllTradesGet 
            && Player.MasterOfNoneGet)
        {
            Player.CollectorGet = true;
            return true; 
        }
        return false;
    }
}
