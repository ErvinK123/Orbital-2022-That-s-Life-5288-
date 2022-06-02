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


    void Start()
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
}
