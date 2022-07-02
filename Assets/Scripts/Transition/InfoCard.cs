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

    // Initialising the text for friend and enemy names
    public Text Friend1Name;
    public Text Friend2Name;
    public Text Enemy1Name;


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

        // Choosing which age picture to show
        agePicture();

        // Displaying the names of friends and enemies
        if (Player.friend1 != null)
        {
            Friend1Name.text = "- " + Player.friend1;
        }

        if (Player.friend2 != null)
        {
            Friend2Name.text = "- " + Player.friend2;
        }

        if (Player.enemy != null)
        {
            Enemy1Name.text = "- " + Player.enemy;
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
