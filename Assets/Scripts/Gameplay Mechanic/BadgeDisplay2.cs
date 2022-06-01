using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadgeDisplay2 : MonoBehaviour
{
    //Initialising the badge locks as GameObject variables
    public GameObject VillainLock;
    public GameObject JackOfAllTradesLock;
    public GameObject MasterOfNoneLock;
    public GameObject CollectorLock;


    void Update()
    {
        if (Player.VillainGet == true)
        {
            VillainLock.SetActive(false);
        }
        else
        {
            VillainLock.SetActive(true);
        }

        if (Player.JackOfAllTradesGet == true)
        {
            JackOfAllTradesLock.SetActive(false);
        }
        else
        {
            JackOfAllTradesLock.SetActive(true);
        }

        if (Player.MasterOfNoneGet == true)
        {
            MasterOfNoneLock.SetActive(false);
        }
        else
        {
            MasterOfNoneLock.SetActive(true);
        }

        //Condition to get Collector Badge is to obtain all other badges
        if ((Player.WorkJunkieGet && Player.SmoothBrainGet && Player.SocialButterflyGet && Player.ShutInGet && Player.PeakHumanGet
            && Player.ZombieGet && Player.HandymanGet && Player.HopelesslyIneptGet && Player.SaintGet && Player.VillainGet
            && Player.JackOfAllTradesGet && Player.MasterOfNoneGet) == true)
        {
            Player.CollectorGet = true;
        }

        if (Player.CollectorGet == true)
        {
            CollectorLock.SetActive(false);
        }
        else
        {
            CollectorLock.SetActive(true);
        }
    }
}
