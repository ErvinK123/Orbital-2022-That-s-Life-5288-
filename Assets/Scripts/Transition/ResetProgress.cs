using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetProgress : MonoBehaviour
{
    public GameObject warningMenu;
 //   public GameObject resetIndicator;
    public GameObject resetConfirmation;

    void Start()
    {
        warningMenu.SetActive(false);
        resetConfirmation.SetActive(false);
    }

    public void reset()
    {
        warningMenu.SetActive(true);
    }

    public void resetYes()
    {
        Player.resetProgress();
        warningMenu.SetActive(false);
        resetConfirmation.SetActive(true);     
    }

    public void resetNo()
    {
        warningMenu.SetActive(false);
    }

    public void exit()
    {
        warningMenu.SetActive(false);
        resetConfirmation.SetActive(false);
    }
}
