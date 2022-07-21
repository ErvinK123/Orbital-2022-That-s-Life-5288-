using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadgeDisplay1 : MonoBehaviour
{
    // Initialising the badge locks as GameObject variables
    public GameObject WorkJunkieLock;
    public GameObject SmoothBrainLock;
    public GameObject SocialButterflyLock;
    public GameObject ShutInLock;
    public GameObject PeakHumanLock;
    public GameObject ZombieLock;
    public GameObject HandymanLock;
    public GameObject HopelesslyIneptLock;
    public GameObject SaintLock;

    // Initialising all the badge popups
    public GameObject WorkJunkieDescription;
    public GameObject SmoothBrainDescription;
    public GameObject SocialButterflyDescription;
    public GameObject ShutInDescription;
    public GameObject PeakHumanDescription;
    public GameObject ZombieDescription;
    public GameObject HandymanDescription;
    public GameObject HopelesslyIneptDescription;
    public GameObject SaintDescription;

    // Initialising the animation for the collector badge
    public GameObject CollectorAnimation;


    void Start()
    {
        Player.collector();
        displayBadge();

        // Setting all the badge popups to be disabled on start
        WorkJunkieDescription.SetActive(false);
        SmoothBrainDescription.SetActive(false);
        SocialButterflyDescription.SetActive(false);
        ShutInDescription.SetActive(false);
        PeakHumanDescription.SetActive(false);
        ZombieDescription.SetActive(false);
        HandymanDescription.SetActive(false);
        HopelesslyIneptDescription.SetActive(false);
        SaintDescription.SetActive(false);

        // Setting the collector animation to be disabled on start
        CollectorAnimation.SetActive(false);

        if ((Player.CollectorGet) && (Player.CollectorFirstTime))
        {
            CollectorAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Collector");
        }
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

    public void workJunkiePopup()
    {
        WorkJunkieDescription.SetActive(true);
    }

    public void workJunkieClose()
    {
        WorkJunkieDescription.SetActive(false);
    }

    public void smoothBrainPopup()
    {
        SmoothBrainDescription.SetActive(true);
    }

    public void smoothBrainClose()
    {
        SmoothBrainDescription.SetActive(false);
    }

    public void socialButterflyPopup()
    {
        SocialButterflyDescription.SetActive(true);
    }

    public void socialButterflyClose()
    {
        SocialButterflyDescription.SetActive(false);
    }

    public void shutInPopup()
    {
        ShutInDescription.SetActive(true);
    }

    public void shutInClose()
    {
        ShutInDescription.SetActive(false);
    }

    public void peakHumanPopup()
    {
        PeakHumanDescription.SetActive(true);
    }

    public void peakHumanClose()
    {
        PeakHumanDescription.SetActive(false);
    }

    public void zombiePopup()
    {
        ZombieDescription.SetActive(true);
    }

    public void zombieClose()
    {
        ZombieDescription.SetActive(false);
    }

    public void handymanPopup()
    {
        HandymanDescription.SetActive(true);
    }

    public void handymanClose()
    {
        HandymanDescription.SetActive(false);
    }

    public void hopelesslyIneptPopup()
    {
        HopelesslyIneptDescription.SetActive(true);
    }

    public void hopelesslyIneptClose()
    {
        HopelesslyIneptDescription.SetActive(false);
    }

    public void saintPopup()
    {
        SaintDescription.SetActive(true);
    }

    public void saintClose()
    {
        SaintDescription.SetActive(false);
    }

    public void collectorAnimationClose()
    {
        CollectorAnimation.SetActive(false);
    }
    
}
