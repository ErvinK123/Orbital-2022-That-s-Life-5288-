using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

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

    // Initialising the trackers for the number of friends and enemies
    public static int friends = 0;
    public static int enemies = 0;

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

    public static Choice[] choiceArr = new Choice[NextPage.numberOfScene * 4];

    public static int Career = 50;
    public static int Popularity = 50;
    public static int Health = 50;
    public static int LifeSkills = 50;
    public static int Morals = 50;

    public static Scenario[] alottedRound;
    public static Scenario[] childAlotted;
    public static Scenario[] teenAlotted;
    public static Scenario[] adultAlotted;
    public static Scenario[] elderAlotted;

    public static string prevSceneName;


    //Friend/ENEMY system 
    public static int friendLimit;
    public static int enemyLimit;
    public static bool addedFriend = false;
    public static bool lostFriend = false;
    public static bool addedEnemy = false;
    public static bool lostEnemy = false;

    //Used when there is a invalid name input
    public static void nameReset()
    {
        Player.name = "";
    }

    //Used when generating a fair start 
    public static void generateFair()
    {
        Player.Career = 50;
        Player.Popularity = 50;
        Player.Health = 50;
        Player.LifeSkills = 50;
        Player.Morals = 50;
    }

    //Used when generating a random start
    public static void generateRandom()
    {
        int first = Random.Range(45, 55);
        int second = Random.Range(45, 55);
        int third = 150 - first - second;
        int fourth = Random.Range(45, 55);
        int fifth = 100 - fourth;
        Player.Career = first;
        Player.Popularity = second;
        Player.Health = third;
        Player.LifeSkills = fourth;
        Player.Morals = fifth;

    }

    // Fills in the Scenarios array in each Scenario class and randomizes them
    public static void setUpScenarios(int child, int teen, int teen1fr, int teen2fr, int teen1en,
        int adult, int adult1fr, int adult2fr, int adult1en, int elder, int elder1fr, int elder2fr, int elder1en)
    {
        childScenario.generateScenarios(child);
        childScenario.gameArr = childScenario.randomizeArray();



        teenScenario.generateScenarios(teen);
        //teenScenario.gameArr = teenScenario.randomizeArray();
        teen1frScenario.generateScenarios(teen1fr);
        //teen1frScenario.gameArr = teen1frScenario.randomizeArray();
        teen2frScenario.generateScenarios(teen2fr);
        //teen2frScenario.gameArr = teen2frScenario.randomizeArray();
        teen1enScenario.generateScenarios(teen1en);
        //teen1enScenario.gameArr = teen1enScenario.randomizeArray();



        adultScenario.generateScenarios(adult);
        //adultScenario.gameArr = adultScenario.randomizeArray();
        adult1frScenario.generateScenarios(adult1fr);
        //adult1frScenario.gameArr = adult1frScenario.randomizeArray();
        adult2frScenario.generateScenarios(adult2fr);
        //adult2frScenario.gameArr = adult2frScenario.randomizeArray();
        adult1enScenario.generateScenarios(adult1en);
        //adult1enScenario.gameArr = adult1enScenario.randomizeArray();


        elderScenario.generateScenarios(elder);
        //elderScenario.gameArr = elderScenario.randomizeArray();
        elder1frScenario.generateScenarios(elder1fr);
        //elder1frScenario.gameArr = elder1frScenario.randomizeArray();
        elder2frScenario.generateScenarios(elder2fr);
        //elder2frScenario.gameArr = elder2frScenario.randomizeArray();
        elder1enScenario.generateScenarios(elder1en);
        //elder1enScenario.gameArr = elder1enScenario.randomizeArray();

    }

    // generates an array of scenario for the player for that run 
    public static void allocateScenarios(string s)
    {
        int num = NextPage.numberOfScene;

        if (s == "Child")
        {
            int combi = Player.nextCombination(Player.friends, Player.enemies);
            Scenario[] pool = Player.arrayCombiner(teenScenario.teenArr, teen1frScenario.teen1frArr, teen1enScenario.teen1enArr, teen2frScenario.teen2frArr, combi);
            Scenario[] temp = new Scenario[NextPage.numberOfScene];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = pool[i];
            }
            Player.teenAlotted = temp;
        }
        else if (s == "Teen")
        {
            int combi = Player.nextCombination(Player.friends, Player.enemies);
            Scenario[] pool = Player.arrayCombiner(adultScenario.adultArr, adult1frScenario.adult1frArr, adult1enScenario.adult1enArr, adult2frScenario.adult2frArr, combi);
            Scenario[] temp = new Scenario[NextPage.numberOfScene];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = pool[i];
            }
            Player.adultAlotted = temp;

        } else if (s == "Adult")
        {
            int combi = Player.nextCombination(Player.friends, Player.enemies);
            Scenario[] pool = Player.arrayCombiner(elderScenario.elderArr, elder1frScenario.elder1frArr, elder1enScenario.elder1enArr, elder2frScenario.elder2frArr, combi);
            Scenario[] temp = new Scenario[NextPage.numberOfScene];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = pool[i];
            }
            Player.elderAlotted = temp;
        } else
        {
            // do nothing 
        }
    }

    public static void allocateChild()
    {
        Scenario[] temp = new Scenario[NextPage.numberOfScene];
        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = childScenario.gameArr[i];
        }
        Player.childAlotted = temp;
    }

    //gives the next pool 
    public static Scenario[] arrayCombiner(Scenario[] arr1, Scenario[] arr2, Scenario[] arr3, Scenario[] arr4, int i)
    {
        if (i == 1)
        {
            //only base pool
            Scenario[] temp = randomizeArray(arr1);
            return temp;
        } else if (i == 2)
        {
            //base + 1 friend
            int total = arr1.Length + arr2.Length;
            Scenario[] temp = new Scenario[total];
            for (int j = 0; j < total; j++)
            {
                if (j < arr1.Length)
                {
                    temp[j] = arr1[j];
                } else
                {
                    temp[j] = arr2[j - arr1.Length];
                }
            }
            temp = randomizeArray(temp);
            return temp;
        } else if (i == 3)
        {
            // base + 1 enemy 
            int total = arr1.Length + arr3.Length;
            Scenario[] temp = new Scenario[total];
            for (int j = 0; j < total; j++)
            {
                if (j < arr1.Length)
                {
                    temp[j] = arr1[j];
                }
                else
                {
                    temp[j] = arr3[j - arr1.Length];
                }
            }
            return temp;
        } else if (i == 4)
        {
            // base + 1 enemy + 1 friend 
            int total = arr1.Length + arr2.Length + arr3.Length;
            Scenario[] temp = new Scenario[total];
            for (int j = 0; j < total; j++)
            {
                if (j < arr1.Length)
                {
                    temp[j] = arr1[j];
                } else if (j < arr1.Length + arr2.Length)
                {
                    temp[j] = arr2[j - arr1.Length];
                }
                else
                {
                    temp[j] = arr3[j - arr1.Length - arr2.Length];
                }
            }
            temp = randomizeArray(temp);
            return temp;
        }
        else if (i == 5)
        {
            // base + 2 friend 
            int total = arr1.Length + arr2.Length + arr3.Length;
            Scenario[] temp = new Scenario[total];
            for (int j = 0; j < total; j++)
            {
                if (j < arr1.Length)
                {
                    temp[j] = arr1[j];
                }
                else if (j < arr1.Length + arr2.Length)
                {
                    temp[j] = arr2[j - arr1.Length];
                }
                else
                {
                    temp[j] = arr3[j - arr1.Length - arr2.Length];
                }
            }
            temp = randomizeArray(temp);
            return temp;
        } else
        {
            // base + 2 friend + 1 enemy 
            int total = arr1.Length + arr2.Length + arr3.Length + arr4.Length;
            Scenario[] temp = new Scenario[total];
            for (int j = 0; j < total; j++)
            {
                if (j < arr1.Length)
                {
                    temp[j] = arr1[j];
                }
                else if (j < arr1.Length + arr2.Length)
                {
                    temp[j] = arr2[j - arr1.Length];
                } else if (j < arr1.Length + arr2.Length + arr3.Length)
                {
                    temp[j] = arr3[j - arr1.Length - arr2.Length];
                } else
                {
                    temp[j] = arr4[j - arr1.Length - arr2.Length - arr3.Length];
                }
            }
            temp = randomizeArray(temp);
            return temp;
        }
    }

    public static int nextCombination(int fr, int en)
    {
        if (fr == 0 && en == 0)
        {
            return 1;
        } else if (fr == 1 && en == 0)
        {
            return 2;
        } else if (fr == 0 && en == 1)
        {
            return 3;
        } else if (fr == 1 && en == 1)
        {
            return 4;
        } else if (fr == 2 && en == 0)
        {
            return 5;
        } else
        {
            return 6;
        }
    }

    public static Scenario[] randomizeArray(Scenario[] arr1)
    {
        Scenario[] newArray = arr1.Clone() as Scenario[];
        for (int i = 0; i < arr1.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    //Store choice given number of button pressed
    public static void storeChoice(int i)
    {
        if (Player.age == "Child")
        {
            Player.choiceArr[Player.scenarios - 1] = new Choice(Player.childAlotted[Player.scenarios - 1], i);
        }
        else if (Player.age == "Teen")
        {
            Player.choiceArr[Player.scenarios - 1] = new Choice(Player.teenAlotted[Player.scenarios - 1 - NextPage.numberOfScene], i);
        }
        else if (Player.age == "Adult")
        {
            Player.choiceArr[Player.scenarios - 1] = new Choice(Player.adultAlotted[Player.scenarios - 1 - 2 * NextPage.numberOfScene], i);
        } else
        {
            Player.choiceArr[Player.scenarios - 1] = new Choice(Player.adultAlotted[Player.scenarios - 1 - 3 * NextPage.numberOfScene], i);
        }
    }

    //get next explanation 
    public static string getNextSceneName(int j)
    {
        if (j == 1)
        {
            return Player.prevSceneName + "E1";
        } else if (j == 2)
        {
            return Player.prevSceneName + "E2";
        } else if (j == 3)
        {
            return Player.prevSceneName + "E3";
        } else
        {
            return Player.prevSceneName + "E4";
        }
    }

    public static string getNextScenarioName()
    {
        int num = NextPage.numberOfScene;
        if (scenarios - 1 < num)
        {
            return childAlotted[scenarios - 1].name;
        } else if (scenarios - 1 < 2 * num)
        {
            return teenAlotted[scenarios - 1 - num].name;
        } else if (scenarios - 1 < 3 * num)
        {
            return adultAlotted[scenarios - 1 - 2 * num].name;
        } else
        {
            return elderAlotted[scenarios - 1 - 3 * num].name;
        }
    }

    //Happens on next scenario in void Start()
    public static void ageUp()
    {
        Player.scenarios += 1;
        int num = NextPage.numberOfScene;
        if (Player.scenarios == num + 1)
        {
            Player.age = "Teen";
            Player.allocateScenarios("Child");
            return;
        } else if (Player.scenarios == 2 * num + 1) {

            Player.age = "Adult";
            Player.allocateScenarios("Teen");
            return;
        } else if (Player.scenarios == 3 * num + 1)
        {
            Player.age = "Elder";
            Player.allocateScenarios("Adult");
            return;
        } else if (Player.scenarios == 4 * num + 1)
        {
            Player.age = "Dead";
            return;
        } else
        {
            //Do nothing
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
        Player.friends = 0;
        Player.enemies = 0;
        Player.addedFriend = false;

        Player.choiceArr = new Choice[4 * NextPage.numberOfScene];
        return;
    }


    //Happens at the  end of a run, determines the title and the attributes of the player
    public static void calculate()
    {
        for (int i = 0; i < 4 * NextPage.numberOfScene; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i < NextPage.numberOfScene)
                {
                    Player.calculateHelper(ChoiceValues.childResult, i, j);
                } else if (i < 2 * NextPage.numberOfScene)
                {
                    Player.calculateHelper(ChoiceValues.teenResult, i, j);
                } else if (i < 3 * NextPage.numberOfScene)
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
            if (tempArr[r] > highestvalue)
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

        foreach (int i in tempArr)
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

    // Debug function to display Player Statistics
    public static void showStatistics()
    {
        Debug.Log(Player.Career);
        Debug.Log(Player.Popularity);
        Debug.Log(Player.Health);
        Debug.Log(Player.LifeSkills);
        Debug.Log(Player.Morals);
    }

    public static void setFElimits(int friend, int enemy)
    {
        Player.friendLimit = friend;
        Player.enemyLimit = enemy;
    }

    //Friend/enemy System 
    public static bool isFriendLimit()
    {
        return Player.friends >= Player.friendLimit;
    }

    public static bool isEnemyLimit()
    {
        return Player.enemies >= Player.enemyLimit;
    }

    public static void addFriend()
    {
        Player.friends++;
        Player.addedFriend = true;
    }

    public static void addEnemy()
    {
        Player.enemies++;
        Player.addedEnemy = true;
    }

    public static void loseFriend()
    {
        Player.friends--;
        Player.lostFriend = true;
    }

    public static void loseEnemy()
    {
        Player.enemies--;
        Player.lostEnemy = true;
    }

    public static void offFEtriggers()
    {
        Player.addedFriend = false;
        Player.addedEnemy = false;
        Player.lostFriend = false;
        Player.lostEnemy = false; 
    }

    public static bool feTrigger()
    {
        return (Player.addedFriend || Player.addedEnemy || Player.lostEnemy || Player.lostFriend);
    }

    public static int getFriends()
    {
        return Player.friends;
    }

    public static string generateFEscreen()
    {
        if (Player.addedFriend)
        {
            return "MakeFriend" + Player.friends;
        } else if (Player.addedEnemy)
        {
            return "MakeEnemy" + Player.enemies;
        } else if (Player.lostFriend)
        {
            return "LostFriend1"; 
        } else if (Player.lostEnemy)
        {
            return "LostEnemy1";
        } else
        {
            return ""; 
        }
    }
}
