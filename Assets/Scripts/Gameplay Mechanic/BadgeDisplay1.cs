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


    
    void Start()
    {
        Player.collector();
        displayBadge();
    }

    public void displayBadge()
    {
        WorkJunkieLock.SetActive(true);
        SmoothBrainLock.SetActive(true);
        SocialButterflyLock.SetActive(true);
        ShutInLock.SetActive(true);
        PeakHumanLock.SetActive(true);
        ZombieLock.SetActive(true);
        HandymanLock.SetActive(true);
        HopelesslyIneptLock.SetActive(true);
        SaintLock.SetActive(true); 

        if (Player.WorkJunkieGet)
        {
            WorkJunkieLock.SetActive(false);
        }

        if (Player.SmoothBrainGet)
        {
            SmoothBrainLock.SetActive(false);
        }

        if (Player.SocialButterflyGet)
        {
            SocialButterflyLock.SetActive(false);
        }
        if (Player.ShutInGet)
        {
            ShutInLock.SetActive(false);
        }
        if (Player.PeakHumanGet)
        {
            PeakHumanLock.SetActive(false);
        }
        if (Player.ZombieGet)
        {
            ZombieLock.SetActive(false);
        }
        if (Player.HandymanGet)
        {
            HandymanLock.SetActive(false);
        }
        if (Player.HopelesslyIneptGet)
        {
            HopelesslyIneptLock.SetActive(false);
        }
        if (Player.SaintGet)
        {
            SaintLock.SetActive(false);
        }
    }
    
}
