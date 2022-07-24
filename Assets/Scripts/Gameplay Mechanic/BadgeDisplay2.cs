using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadgeDisplay2 : MonoBehaviour
{
    // Initialising the badge locks as GameObject variables
    public GameObject VillainLock;
    public GameObject JackOfAllTradesLock;
    public GameObject MasterOfNoneLock;
    public GameObject CollectorLock;

    // Initialising all the badge popups
    public GameObject VillainDescription;
    public GameObject JackOfAllTradesDescription;
    public GameObject MasterOfNoneDescription;
    public GameObject CollectorDescription;


    void Start()
    {
        //displayBadge2();

        //Setting all the badge popups to be disabled on start
        VillainDescription.SetActive(false);
        JackOfAllTradesDescription.SetActive(false);
        MasterOfNoneDescription.SetActive(false);
        CollectorDescription.SetActive(false);
    }

    void Update()
    {
        displayBadge2();
    }

    public void displayBadge2()
    {
        VillainLock.SetActive(true);
        JackOfAllTradesLock.SetActive(true);
        MasterOfNoneLock.SetActive(true);
        CollectorLock.SetActive(true);
        
        if (Player.VillainGet)
        {
            VillainLock.SetActive(false);
        }

        if (Player.JackOfAllTradesGet)
        {
            JackOfAllTradesLock.SetActive(false);
        }

        if (Player.MasterOfNoneGet)
        {
            MasterOfNoneLock.SetActive(false);
        }

        if (Player.CollectorGet)
        {
            CollectorLock.SetActive(false);
        }
        
    }

    public void villainPopup()
    {
        VillainDescription.SetActive(true);
    }

    public void villainClose()
    {
        VillainDescription.SetActive(false);
    }

    public void jackOfAllTradesPopup()
    {
        JackOfAllTradesDescription.SetActive(true);
    }

    public void jackOfAllTradesClose()
    {
        JackOfAllTradesDescription.SetActive(false);
    }

    public void masterOfNonePopup()
    {
        MasterOfNoneDescription.SetActive(true);
    }

    public void masterOfNoneClose()
    {
        MasterOfNoneDescription.SetActive(false);
    }

    public void collectorPopup()
    {
        CollectorDescription.SetActive(true);
    }

    public void collectorClose()
    {
        CollectorDescription.SetActive(false);
    }
}
