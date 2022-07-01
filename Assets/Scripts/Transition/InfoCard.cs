using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoCard : MonoBehaviour
{
    // Initialising the Game Object variables
    public GameObject InformationCard;
    public GameObject ChildImage;
    public GameObject TeenImage;
    public GameObject AdultImage;
    public GameObject ElderImage;
    public GameObject Friend1Name;
    public GameObject Friend2Name;
    public GameObject Enemy1Name;


    // Function to choose which age period picture to use
    public void agePicture()
    {
        if (Player.age == "Child")
        {
            ChildImage.SetActive(true);
        } else if (Player.age == "Teen")
        {
            ChildImage.SetActive(false);
            TeenImage.SetActive(true);
        } else if (Player.age == "Adult")
        {
            TeenImage.SetActive(false);
            AdultImage.SetActive(true);
        } else
        {
            AdultImage.SetActive(false);
            ElderImage.SetActive(true);
        }
    }

    void Start()
    {
        InformationCard.SetActive(false);

        ChildImage.SetActive(false);
        TeenImage.SetActive(false);
        AdultImage.SetActive(false);
        ElderImage.SetActive(false);
        Friend1Name.SetActive(false);
        Friend2Name.SetActive(false);
        Enemy1Name.SetActive(false);

        // Choosing which age picture to show
        agePicture();

        // Temporary code to display names of current friends and enemies
        if (Player.friends == 1)
        {
            Friend1Name.SetActive(true);
            Friend2Name.SetActive(false);
        } else if (Player.friends == 2)
        {
            Friend1Name.SetActive(true);
            Friend2Name.SetActive(true);
        } else
        {
            Friend1Name.SetActive(false);
            Friend2Name.SetActive(false);
        }

        if (Player.enemies == 1)
        {
            Enemy1Name.SetActive(true);
        } else
        {
            Enemy1Name.SetActive(false);
        }
    }

    public void open()
    {
        InformationCard.SetActive(true);
    }

    public void close()
    {
        InformationCard.SetActive(false);
    }

}
