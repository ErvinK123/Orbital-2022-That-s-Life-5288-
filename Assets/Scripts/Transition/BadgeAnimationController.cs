using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadgeAnimationController : MonoBehaviour
{
    // Initialising the badge animations as game objects
    public GameObject WorkJunkieAnimation;
    public GameObject SmoothBrainAnimation;
    public GameObject SocialButterflyAnimation;
    public GameObject ShutInAnimation;
    public GameObject PeakHumanAnimation;
    public GameObject ZombieAnimation;
    public GameObject HandymanAnimation;
    public GameObject HopelesslyIneptAnimation;
    public GameObject SaintAnimation;
    public GameObject VillainAnimation;
    public GameObject JackOfAllTradesAnimation;
    public GameObject MasterOfNoneAnimation;

    // Chooses whether to play the appropriate badge animation
    public void showAnimation()
    {
        if ((Player.WorkJunkieGet) && (Player.WorkJunkieFirstTime))
        {
            WorkJunkieAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Work Junkie");
        }

        if ((Player.SmoothBrainGet) && (Player.SmoothBrainFirstTime))
        {
            SmoothBrainAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Smooth Brain");
        }

        if ((Player.SocialButterflyGet) && (Player.SocialButterflyFirstTime))
        {
            SocialButterflyAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Social Butterfly");
        }

        if ((Player.ShutInGet) && (Player.ShutInFirstTime))
        {
            ShutInAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Shut-In");
        }

        if ((Player.PeakHumanGet) && (Player.PeakHumanFirstTime))
        {
            PeakHumanAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Peak Human");
        }

        if ((Player.ZombieGet) && (Player.ZombieFirstTime))
        {
            ZombieAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Zombie");
        }

        if ((Player.HandymanGet) && (Player.HandymanFirstTime))
        {
            HandymanAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Handyman");
        }

        if ((Player.HopelesslyIneptGet) && (Player.HopelesslyIneptFirstTime))
        {
            HopelesslyIneptAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Hopelessly Inept");
        }

        if ((Player.SaintGet) && (Player.SaintFirstTime))
        {
            SaintAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Saint");
        }

        if ((Player.VillainGet) && (Player.VillainFirstTime))
        {
            VillainAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Villain");
        }

        if ((Player.JackOfAllTradesGet) && (Player.JackOfAllTradesFirstTime))
        {
            JackOfAllTradesAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Jack of All Trades");
        }

        if ((Player.MasterOfNoneGet) && (Player.MasterOfNoneFirstTime))
        {
            MasterOfNoneAnimation.SetActive(true);
            Player.firstTimeBadgeGet("Master of None");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialising all the badge animation game objects to be inactive
        WorkJunkieAnimation.SetActive(false);
        SmoothBrainAnimation.SetActive(false);
        SocialButterflyAnimation.SetActive(false);
        ShutInAnimation.SetActive(false);
        PeakHumanAnimation.SetActive(false);
        ZombieAnimation.SetActive(false);
        HandymanAnimation.SetActive(false);
        HopelesslyIneptAnimation.SetActive(false);
        SaintAnimation.SetActive(false);
        VillainAnimation.SetActive(false);
        JackOfAllTradesAnimation.SetActive(false);
        MasterOfNoneAnimation.SetActive(false);

        showAnimation();
    }

    public void WorkJunkieClose()
    {
        WorkJunkieAnimation.SetActive(false);
    }

    public void SmoothBrainClose()
    {
        SmoothBrainAnimation.SetActive(false);
    }

    public void SocialButterflyClose()
    {
        SocialButterflyAnimation.SetActive(false);
    }

    public void ShutInClose()
    {
        ShutInAnimation.SetActive(false);
    }

    public void PeakHumanClose()
    {
        PeakHumanAnimation.SetActive(false);
    }

    public void ZombieClose()
    {
        ZombieAnimation.SetActive(false);
    }

    public void HandymanClose()
    {
        HandymanAnimation.SetActive(false);
    }

    public void HopelesslyIneptClose()
    {
        HopelesslyIneptAnimation.SetActive(false);
    }

    public void SaintClose()
    {
        SaintAnimation.SetActive(false);
    }

    public void VillainClose()
    {
        VillainAnimation.SetActive(false);
    }

    public void JackOfAllTradesClose()
    {
        JackOfAllTradesAnimation.SetActive(false);
    }

    public void MasterOfNoneClose()
    {
        MasterOfNoneAnimation.SetActive(false);
    }
}
