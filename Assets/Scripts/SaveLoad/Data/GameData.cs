using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GameData
{
    public int scenarios;
    public string name;
    public string age;
    public int friends;
    public int enemies;

    public int Career;
    public int Popularity;
    public int Health;
    public int LifeSkills;
    public int Morals;

    public string prevSceneName;

    public int friendLimit;
    public int enemyLimit;
    public string friend1;
    public string friend2;
    public string enemy;

    public bool transition;

    public bool WorkJunkieGet;
    public bool SmoothBrainGet;
    public bool SocialButterflyGet;
    public bool ShutInGet;
    public bool PeakHumanGet;
    public bool ZombieGet;
    public bool HandymanGet;
    public bool HopelesslyIneptGet;
    public bool SaintGet;
    public bool VillainGet;
    public bool JackOfAllTradesGet;
    public bool MasterOfNoneGet;
    public bool CollectorGet;

    public int teenPointer;
    public int adultPointer;
    public int elderPointer;

    public bool addedFriend1;
    public bool addedFriend2;
    public bool lostFriend1;
    public bool lostFriend2;
    public bool addedEnemy;
    public bool lostEnemy;

    public string currScene;

    public List<Choice> choices;
    public List<Scenario> childList;
    public List<Scenario> teenList;
    public List<Scenario> adultList;
    public List<Scenario> elderList;

    public List<string> friend1List;
    public List<string> friend2List;
    public List<string> enemyList;

    public int friend1Pointer;
    public int friend2Pointer;
    public int enemyPointer;


    public bool WorkJunkieFirstTime;
    public bool SmoothBrainFirstTime;
    public bool SocialButterflyFirstTime;
    public bool ShutInFirstTime;
    public bool PeakHumanFirstTime;
    public bool ZombieFirstTime;
    public bool HandymanFirstTime;
    public bool HopelesslyIneptFirstTime;
    public bool SaintFirstTime;
    public bool VillainFirstTime;
    public bool JackOfAllTradesFirstTime;
    public bool MasterOfNoneFirstTime;
    public bool CollectorFirstTime;

    public GameData()
    {   
        this.scenarios = 0;
    }
}
