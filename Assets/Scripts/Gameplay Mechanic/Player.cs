using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;




[Serializable]
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

[Serializable]
public struct Scenario
{
    public int id;
    public string name;

    // type 1:norm 2:onefr 3:twofr 4:oneen 5: dummy 
    public int type;

    public Scenario(int id, string name, int type)
    {
        this.id = id;
        this.name = name;
        this.type = type;
    }
}

public class Player : MonoBehaviour, IDataPersistance
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

    public static List<Choice> choices;


    public static int Career = 50;
    public static int Popularity = 50;
    public static int Health = 50;
    public static int LifeSkills = 50;
    public static int Morals = 50;

    //public static Scenario[] alottedRound;
    public static Scenario[] childAlotted;
    public static Scenario[] teenAlotted;
    public static Scenario[] adultAlotted;
    public static Scenario[] elderAlotted;

    public static int teenPointer = 0;
    public static int adultPointer = 0;
    public static int elderPointer = 0;


    public static string prevSceneName;
    public static string currScene;


    //Friend/ENEMY system 
    public static int friendLimit;
    public static int enemyLimit;
    public static bool addedFriend1 = false;
    public static bool addedFriend2 = false;
    public static bool lostFriend1 = false;
    public static bool lostFriend2 = false;
    public static bool addedEnemy = false;
    public static bool lostEnemy = false;

    public static string friend1;
    public static string friend2;
    public static string enemy;

    //Transitions 
    public static bool transition = false;


    //SaveLoad 
    public void LoadData(GameData data)
    {
        scenarios = data.scenarios;
        name = data.name;
        age = data.age;
        friends = data.friends;
        enemies = data.enemies;
        Career = data.Career;
        Popularity = data.Popularity;
        Health = data.Health;
        LifeSkills = data.LifeSkills;
        Morals = data.Morals;
        friendLimit = data.friendLimit;
        enemyLimit = data.enemyLimit;
        friend1 = data.friend1;
        friend2 = data.friend2;
        enemy = data.enemy;
        transition = data.transition; 
        prevSceneName = data.prevSceneName;

        teenPointer = data.teenPointer;
        adultPointer = data.adultPointer;
        elderPointer = data.elderPointer;

        WorkJunkieGet = data.WorkJunkieGet;
        SmoothBrainGet = data.SmoothBrainGet;
        SocialButterflyGet = data.SmoothBrainGet;
        ShutInGet = data.ShutInGet;
        PeakHumanGet = data.PeakHumanGet;
        ZombieGet = data.ZombieGet;
        HandymanGet = data.HandymanGet;
        HopelesslyIneptGet = data.HopelesslyIneptGet;
        SaintGet = data.SaintGet;
        VillainGet = data.VillainGet;
        JackOfAllTradesGet = data.JackOfAllTradesGet;
        MasterOfNoneGet = data.MasterOfNoneGet;
        CollectorGet = data.CollectorGet;

        addedFriend1 = data.addedFriend1;
        addedFriend2 = data.addedFriend2;
        lostFriend1 = data.lostFriend1;
        lostFriend2 = data.lostFriend2;
        addedEnemy = data.addedEnemy;
        lostEnemy = data.lostEnemy;
        currScene = data.currScene; 

        choices = data.choices;
    }

    public void SaveData(ref GameData data)
    {
        Debug.Log("I HAVE RUN THE PLAYER CLASS SAVE DATA");
        data.scenarios = scenarios;
        data.name = name;
        data.age = age;
        data.friends = friends;
        data.enemies = enemies;
        data.Career = Career;
        data.Popularity = Popularity;
        data.Health = Health;
        data.LifeSkills = LifeSkills;
        data.Morals = Morals;
        data.friendLimit = friendLimit;
        data.enemyLimit = enemyLimit;
        data.friend1 = friend1;
        data.friend2 = friend2;
        data.enemy = enemy;
        data.prevSceneName = prevSceneName;
        data.currScene = currScene;
        data.transition = transition;

        data.teenPointer = teenPointer;
        data.adultPointer = adultPointer;
        data.elderPointer = elderPointer; 

        data.WorkJunkieGet = WorkJunkieGet;
        data.SmoothBrainGet = SmoothBrainGet;
        data.SocialButterflyGet = SmoothBrainGet;
        data.ShutInGet = ShutInGet;
        data.PeakHumanGet = PeakHumanGet;
        data.ZombieGet = ZombieGet;
        data.HandymanGet = HandymanGet;
        data.HopelesslyIneptGet = HopelesslyIneptGet;
        data.SaintGet = SaintGet;
        data.VillainGet = VillainGet;
        data.JackOfAllTradesGet = JackOfAllTradesGet;
        data.MasterOfNoneGet = MasterOfNoneGet;
        data.CollectorGet = CollectorGet;
        data.choices = choices;

        data.addedFriend1 = addedFriend1;
        data.addedFriend2 = addedFriend2;
        data.lostFriend1 = lostFriend1;
        data.lostFriend2 = lostFriend2;
        data.addedEnemy = addedEnemy;
        data.lostEnemy = lostEnemy;
    }




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

    // Function to determine which introduction page to use when the Random button is selected in the name page
    public static string useIntro()
    {
        int[] initAttributes = { Player.Career, Player.Popularity, Player.Health, Player.LifeSkills, Player.Morals };
        string[] introScenes = { "CareerBestIntro", "PopularityBestIntro", "HealthBestIntro", "LifeskillsBestIntro", "MoralsBestIntro" };
        int temp = Player.Career;
        string intro = "CareerBestIntro";
        
        for (int i = 1; i < 5; i++)
        {
            if (initAttributes[i] > temp)
            {
                temp = initAttributes[i];
                intro = introScenes[i];
            }
        }
        return intro;
    }

    public static int childScene = 10;

    public static int teenScene = 6;
    public static int teen1frScene = 2;
    public static int teen2frScene = 2;
    public static int teen1enScene = 2;

    public static int adultScene = 10;
    public static int adult1frScene = 2;
    public static int adult2frScene = 2;
    public static int adult1enScene = 2;

    public static int elderlyScene = 10;
    public static int elderly1frScene = 2;
    public static int elderly2frScene = 2;
    public static int elderly1enScene = 2;

    // Fills in the Scenarios array in each Scenario class and randomizes them
    public static void setUpScenarios(int child, int teen, int teen1fr, int teen2fr, int teen1en,
        int adult, int adult1fr, int adult2fr, int adult1en, int elder, int elder1fr, int elder2fr, int elder1en)
    {
        childScenario.generateScenarios(child);
        childScenario.gameArr = childScenario.randomizeArray();



        teenScenario.generateScenarios(teen);
        teen1frScenario.generateScenarios(teen1fr);
        teen2frScenario.generateScenarios(teen2fr);
        teen1enScenario.generateScenarios(teen1en);



        adultScenario.generateScenarios(adult);
        adult1frScenario.generateScenarios(adult1fr);
        adult2frScenario.generateScenarios(adult2fr);
        adult1enScenario.generateScenarios(adult1en);


        elderScenario.generateScenarios(elder);
        elder1frScenario.generateScenarios(elder1fr);
        elder2frScenario.generateScenarios(elder2fr);
        elder1enScenario.generateScenarios(elder1en);

    }

    public static void initializeChoices()
    {
        for (int i = 0; i < choiceArr.Length; i++)
        {
            choiceArr[i] = new Choice(new Scenario(1, "", 5), 1);
        }

        choices = new List<Choice>() ;
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
    

    public static Scenario[] generateArray(Scenario[] arr1, Scenario[] arr2, Scenario[] arr3, Scenario[] arr4)
    {
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
            }
            else if (j < arr1.Length + arr2.Length + arr3.Length)
            {
                temp[j] = arr3[j - arr1.Length - arr2.Length];
            }
            else
            {
                temp[j] = arr4[j - arr1.Length - arr2.Length - arr3.Length];
            }
        }
        temp = randomizeArray(temp);
        return temp;
    }

    public static void allocateScenarios(Scenario[] arr1, string phase)
    {
        if (phase == "Child")
        {
            Player.childAlotted = arr1;
            return; 
        } else if (phase == "Teen")
        {
            Player.teenAlotted = arr1;
            return; 
        } else if (phase == "Adult")
        {
            Player.adultAlotted = arr1;
            return; 
        } else
        {
            Player.elderAlotted = arr1;
            return; 
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
            //Debug.Log("New Choice from child alotted name" + Player.childAlotted[Player.scenarios-1].name);
            //Player.choiceArr[Player.scenarios - 1] = new Choice(Player.childAlotted[Player.scenarios - 1], i);
            choices.Add(new Choice(Player.childAlotted[Player.scenarios - 1], i));
        }
        else if (Player.age == "Teen")
        {
            //Debug.Log("New Choice from teen alotted name" + Player.teenAlotted[teenPointer-1].name);
            //Player.choiceArr[Player.scenarios - 1] = new Choice(Player.teenAlotted[teenPointer-1], i);
            choices.Add(new Choice(Player.teenAlotted[teenPointer - 1], i));
        }
        else if (Player.age == "Adult")
        {
            //Debug.Log("New Choice from adult alotted name:" + Player.adultAlotted[adultPointer-1].name);
            //Player.choiceArr[Player.scenarios - 1] = new Choice(Player.adultAlotted[adultPointer-1], i);
            choices.Add(new Choice(Player.adultAlotted[adultPointer - 1], i));
        } else
        {
            //Debug.Log("New Choice from elder alotted name: " + Player.elderAlotted[elderPointer-1].name);
            //Player.choiceArr[Player.scenarios - 1] = new Choice(Player.elderAlotted[elderPointer-1], i);
            choices.Add(new Choice(Player.elderAlotted[elderPointer - 1], i));
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

    public static string getNextScenarioName(string s)
    {
        int num = NextPage.numberOfScene;
        //Player.adjustPointer(s);
        if (scenarios - 1 < num)
        {
            return childAlotted[scenarios - 1].name;
        }
        else if (scenarios - 1 < 2 * num)
        {   
            return teenAlotted[teenPointer].name;
        }
        else if (scenarios - 1 < 3 * num)
        {
            return adultAlotted[adultPointer].name;
        }
        else
        {
            return elderAlotted[elderPointer].name;
        }

    }

    public static void adjustPointer(string s)
    {
        if (s == "Child")
        {
            return; 
        } else if (s == "Teen")
        {   
            teenPointer = Player.scenarioChecker(teenPointer, teenAlotted);

        } else if (s == "Adult")
        {
            adultPointer = Player.scenarioChecker(adultPointer, adultAlotted);
        } else
        {
            elderPointer = Player.scenarioChecker(elderPointer, elderAlotted);
        }
    }

    public static int scenarioChecker(int i, Scenario[] arr)
    {
        for (int r = i; r < arr.Length; r++)
        {
            if (Player.nextCombination(Player.friends, Player.enemies) == 1)
            {
                if (arr[r].type == 1)
                {
                    //Debug.Log(Player.nextCombination(Player.friends, Player.enemies) + ": " + "pooled from position" + r);
                    return r;
                }
            }
            else if (Player.nextCombination(Player.friends, Player.enemies) == 2)
            {
                if (arr[r].type == 1 || arr[r].type == 2)
                {
                    //Debug.Log(Player.nextCombination(Player.friends, Player.enemies) + ": " + "pooled from position" + r);
                    return r;
                }
            }
            else if (Player.nextCombination(Player.friends, Player.enemies) == 3)
            {
                if (arr[r].type == 1 || arr[r].type == 4)
                {
                    //Debug.Log(Player.nextCombination(Player.friends, Player.enemies) + ": " + "pooled from position" + r);
                    return r;
                }

            }
            else if (Player.nextCombination(Player.friends, Player.enemies) == 4)
            {
                if (arr[r].type == 1 || arr[r].type == 2 || arr[r].type == 4)
                {
                    //Debug.Log(Player.nextCombination(Player.friends, Player.enemies) + ": " + "pooled from position" + r);
                    return r;
                }
            }
            else if (Player.nextCombination(Player.friends, Player.enemies) == 5)
            {
                if (arr[r].type == 1 || arr[r].type == 2 || arr[r].type == 3)
                {
                    //Debug.Log(Player.nextCombination(Player.friends, Player.enemies) + ": " + "pooled from position" + r);
                    return r;
                }
            }
            else
            {
                if (arr[r].type == 1 || arr[r].type == 2 || arr[r].type == 3 || arr[r].type == 4)
                {
                    //Debug.Log(Player.nextCombination(Player.friends, Player.enemies) + ": " + "pooled from position" + r);
                    return r;
                }
            }
        }
        return i;
    }

    public static void increasePointer(string s)
    {
        if (s == "Child")
        {
            return; 
        } else if(s == "Teen")
        {
            teenPointer++;
        } else if(s == "Adult")
        {
            adultPointer++; 
        } else
        {
            elderPointer++;
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
            Player.adjustPointer("Teen"); 
            return;
        } else if (Player.scenarios == 2 * num + 1) {

            Player.age = "Adult";
            Player.adjustPointer("Adult");
            return;
        } else if (Player.scenarios == 3 * num + 1)
        {
            Player.age = "Elder";
            Player.adjustPointer("Elder");
            return;
        } else if (Player.scenarios == 4 * num + 1)
        {
            Player.age = "Dead";
            return;
        } else if (Player.age == "Teen")
        {
            Player.adjustPointer("Teen");
        } else if (Player.age == "Adult")
        {
            Player.adjustPointer("Adult"); 
        } else if (Player.age == "Elder")
        {
            Player.adjustPointer("Elder");
        } else
        {
            //Do nothing
        }
    }

    // Returns the corresponding number to displayer to correct player's age
    public static int gameAge()
    {
        int ScenarioNum = 1;

        if (Player.age != "Dead")
        {
            ScenarioNum = Player.scenarios;
        } else
        {
            ScenarioNum = Player.scenarios - 1;
        }

        return ScenarioNum;
    }

    // Function to choose what age to display as the player's age according to the current scenario number
    public static string displayAge()
    {
        // Child period
        if (Player.gameAge() == 1)
        {
            return "6";
        }
        
        if (Player.gameAge() == 2)
        {
            return "7";
        }

        if (Player.gameAge() == 3)
        {
            return "8";
        }

        if (Player.gameAge() == 4)
        {
            return "10";
        }

        if (Player.gameAge() == 5)
        {
            return "12";
        }

        //Teen period
        if (Player.gameAge() == 6)
        {
            return "13";
        }

        if (Player.gameAge() == 7)
        {
            return "14";
        }

        if (Player.gameAge() == 8)
        {
            return "15";
        }

        if (Player.gameAge() == 9)
        {
            return "17";
        }

        if (Player.gameAge() == 10)
        {
            return "19";
        }

        // Adult period
        if (Player.gameAge() == 11)
        {
            return "25";
        }

        if (Player.gameAge() == 12)
        {
            return "30";
        }

        if (Player.gameAge() == 13)
        {
            return "35";
        }

        if (Player.gameAge() == 14)
        {
            return "45";
        }

        if (Player.gameAge() == 15)
        {
            return "55";
        }

        // Elder period
        if (Player.gameAge() == 16)
        {
            return "65";
        }

        if (Player.gameAge() == 17)
        {
            return "70";
        }

        if (Player.gameAge() == 18)
        {
            return "75";
        }

        if (Player.gameAge() == 19)
        {
            return "80";
        }

        if (Player.gameAge() == 20)
        {
            return "85";
        }

        // invalid scenario number
        return "0";
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
        Player.addedFriend1 = false;
        Player.addedFriend2 = false;
        Player.teenPointer = 0;
        Player.adultPointer = 0;
        Player.elderPointer = 0;
        Player.friend1 = null;
        Player.friend2 = null;
        Player.enemy = null;
        FriendEnemy.friend1Pointer = 0;
        FriendEnemy.friend2Pointer = 0;
        FriendEnemy.enemyPointer = 0;
        Player.choices = null;

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
                    Player.calculateHelper(ChoiceValues.teenResult, ChoiceValues.teen1frResult, ChoiceValues.teen2frResult, ChoiceValues.teen1enResult, i, j);
                } else if (i < 3 * NextPage.numberOfScene)
                {                   
                    Player.calculateHelper(ChoiceValues.adultResult, ChoiceValues.adult1frResult, ChoiceValues.adult2frResult, ChoiceValues.adult1enResult, i, j);
                } else
                {                    
                    Player.calculateHelper(ChoiceValues.elderResult, ChoiceValues.elder1frResult, ChoiceValues.elder2frResult, ChoiceValues.elder1enResult, i, j);
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
    public static void calculateHelper(int[,,] normArr, int first, int second)
    {
        int temp = choices[first].scenario.type;

        if (temp == 1)
        {
            if (second == 0)
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]);
                //Player.Career += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Career += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second]; 
                return;
            }
            else if (second == 1)
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]);
                //Player.Popularity += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Popularity += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 2)
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]); 
                //Player.Health += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Health += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 3)
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]); 
                //Player.LifeSkills += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.LifeSkills += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]); 
                //Player.Morals += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Morals += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
        } else
        {
            return; 
        }
    }


    // Used in calculate : Cross checks the choices made by player and changes player attribute 
    public static void calculateHelper(int[,,] normArr, int[,,] onefr, int[,,] twofr, int[,,] oneen, int first, int second)
    {
        int temp = choices[first].scenario.type;

        if (temp == 1)
        {
            if (second == 0)
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]);
                //Player.Career += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Career += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 1)
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]);
                //Player.Popularity += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Popularity += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 2)
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]);
               // Player.Health += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Health += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 3)
            {
               //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]); 
                //Player.LifeSkills += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.LifeSkills += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else
            {
                //Debug.Log(normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second]);
                //Player.Morals += normArr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Morals += normArr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
        }

        if (temp == 2)
        {
            //Debug.Log("shoudlnt be here");
            if (second == 0)
            {
                //Player.Career += onefr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Career += onefr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 1)
            {
                //Player.Popularity += onefr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Popularity += onefr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 2)
            {
                //Player.Health += onefr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Health += onefr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 3)
            {
                //Player.LifeSkills += onefr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.LifeSkills += onefr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else
            {
                //Player.Morals += onefr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Morals += onefr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
        }

        if(temp == 3)
        {
            if (second == 0)
            {
                //Player.Career += twofr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Career += twofr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 1)
            {
                //Player.Popularity += twofr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Popularity += twofr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 2)
            {
                //Player.Health += twofr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Health += twofr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 3)
            {
                //Player.LifeSkills += twofr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.LifeSkills += twofr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else
            {
                //Player.Morals += twofr[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Morals += twofr[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
        }

        if (temp == 4)
        {
            if (second == 0)
            {
                //Player.Career += oneen[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Career += oneen[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 1)
            {
                //Player.Popularity += oneen[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Popularity += oneen[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 2)
            {
                //Player.Health += oneen[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Health += oneen[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else if (second == 3)
            {
                //Player.LifeSkills += oneen[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.LifeSkills += oneen[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
            else
            {
                //Player.Morals += oneen[choiceArr[first].scenario.id - 1, choiceArr[first].choice - 1, second];
                Player.Morals += oneen[choices[first].scenario.id - 1, choices[first].choice - 1, second];
                return;
            }
        }

        if (temp == 5)
        {
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

    public static void addFriend1()
    {
        Debug.Log("AddFriend");
        Player.friend1 = FriendEnemy.friend1Arr[FriendEnemy.friend1Pointer];
        FriendEnemy.increasePointer(1);
        Player.friends++;
        Player.addedFriend1 = true;
    }

    public static void addFriend2()
    {
        Player.friend2 = FriendEnemy.friend2Arr[FriendEnemy.friend2Pointer];
        FriendEnemy.increasePointer(2);
        Player.friends++;
        Player.addedFriend2 = true;
    }

    public static void addEnemy()
    {
        Player.enemy = FriendEnemy.enemyArr[FriendEnemy.enemyPointer];
        FriendEnemy.increasePointer(3);
        Player.enemies++;
        Player.addedEnemy = true;
    }

    public static void loseFriend1()
    {
        if (Player.friend1 != null && Player.friend1 != "")
        {
            FriendEnemy.increasePointer(1);
            Player.friend1 = null;
            Player.friends--;
            Player.lostFriend1 = true;
        } 
    }

    public static void loseFriend2()
    {
        if (Player.friend2 != null && Player.friend2 != "")
        {
            FriendEnemy.increasePointer(2); 
            Player.friend2 = null;
            Player.friends--;
            Player.lostFriend2 = true;
        }
    }

    public static void loseEnemy()
    {
        if (Player.enemy != null && Player.enemy != "")
        {
            FriendEnemy.increasePointer(3);
            Player.enemy = null;
            Player.enemies--;
            Player.lostEnemy = true;
        }
    }

    public static void offFEtriggers()
    {
        Player.addedFriend1 = false;
        Player.addedFriend2 = false; 
        Player.addedEnemy = false;
        Player.lostFriend1 = false;
        Player.lostFriend2 = false; 
        Player.lostEnemy = false; 
    }

    public static bool feTrigger()
    {
        return (Player.addedFriend1 || Player.addedFriend2 || Player.addedEnemy || Player.lostEnemy || Player.lostFriend1 || Player.lostFriend2);
    }

    public static int getFriends()
    {
        return Player.friends;
    }

    public static string generateFEscreen()
    {
        if (Player.addedFriend1)
        {
            return "MakeFriend1";
        }
        else if (Player.addedFriend2)
        {
            return "MakeFriend2";
        }
        else if (Player.addedEnemy)
        {
            return "MakeEnemy" + Player.enemies;
        }
        else if (Player.lostFriend1)
        {
            return "LostFriend1";
        }
        else if (Player.lostFriend2)
        {
            return "LostFriend2";
        } else if (Player.lostEnemy)
        {
            return "LostEnemy1";
        }
        else
        {
            return "";
        }
    }

    public static bool transitionTrigger()
    {
        return Player.transition;
    }

    public static void setTransition()
    {
        int temp = NextPage.numberOfScene;
        if (Player.scenarios == temp || Player.scenarios == temp*2 || Player.scenarios == temp*3)
        {
            Player.transition = true;
            return; 
        }
    }

    public static string generateTransition()
    {
        Player.transition = false; 
        if (Player.age == "Child")
        {
            return "ChildToTeen"; 
        } else if (Player.age == "Teen") 
        {
            return "TeenToAdult"; 
        } else
        {
            return "AdultToElder";
        }

    }

    public static void printName()
    {
        for (int i = 0; i < childAlotted.Length; i++)
        {
            Debug.Log(childAlotted[i].name);
        }
        for (int i = 0; i < teenAlotted.Length; i++)
        {
            Debug.Log(teenAlotted[i].name);
        }
        for (int i = 0; i < adultAlotted.Length; i++)
        {
            Debug.Log(adultAlotted[i].name);
        }
        for (int i = 0; i < elderAlotted.Length; i++)
        {
            Debug.Log(elderAlotted[i].name);
        }

    }
    
    public static void testFE()
    {
        //Debug.Log("N"); 
        //Debug.Log("Friend1: " + friend1);
        //Debug.Log("Friend2: " + friend2);
        //Debug.Log("Enemy: " + enemy);

        Debug.Log("T: " +teenPointer);
        Debug.Log("A" + adultPointer);
        Debug.Log("E" +elderPointer);
    }

}
