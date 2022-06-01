using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadgeDisplay1 : MonoBehaviour
{
    //Initialising the badge locks as GameObject variables
    public GameObject WorkJunkieLock;
    public GameObject SmoothBrainLock;
    public GameObject SocialButterflyLock;
    public GameObject ShutInLock;
    public GameObject PeakHumanLock;
    public GameObject ZombieLock;
    public GameObject HandymanLock;
    public GameObject HopelesslyIneptLock;
    public GameObject SaintLock;


    void Update()
    {
        if (Player.WorkJunkieGet == true)
        {
            WorkJunkieLock.SetActive(false);
        }
        else
        {
            WorkJunkieLock.SetActive(true);
        }
        
        if (Player.SmoothBrainGet == true)
        {
            SmoothBrainLock.SetActive(false);
        }
        else
        {
            SmoothBrainLock.SetActive(true);
        }

        if (Player.SocialButterflyGet == true)
        {
            SocialButterflyLock.SetActive(false);
        }
        else
        {
            SocialButterflyLock.SetActive(true);
        }

        if (Player.ShutInGet == true)
        {
            ShutInLock.SetActive(false);
        }
        else
        {
            ShutInLock.SetActive(true);
        }

        if (Player.PeakHumanGet == true)
        {
            PeakHumanLock.SetActive(false);
        }
        else
        {
            PeakHumanLock.SetActive(true);
        }

        if (Player.ZombieGet == true)
        {
            ZombieLock.SetActive(false);
        }
        else
        {
            ZombieLock.SetActive(true);
        }

        if (Player.HandymanGet == true)
        {
            HandymanLock.SetActive(false);
        }
        else
        {
            HandymanLock.SetActive(true);
        }

        if (Player.HopelesslyIneptGet == true)
        {
            HopelesslyIneptLock.SetActive(false);
        }
        else
        {
            HopelesslyIneptLock.SetActive(true);
        }

        if (Player.SaintGet == true)
        {
            SaintLock.SetActive(false);
        }
        else
        {
            SaintLock.SetActive(true);
        }
    } 
}
