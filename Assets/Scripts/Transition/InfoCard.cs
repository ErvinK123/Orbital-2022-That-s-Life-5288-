using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCard : MonoBehaviour
{
    // Initialising the Game Object variables
    public GameObject InformationCard;
    public GameObject ChildImage;
    public GameObject TeenImage;
    public GameObject AdultImage;
    public GameObject ElderImage;


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

        agePicture();
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
