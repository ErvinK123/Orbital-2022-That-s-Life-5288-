using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStatistics : MonoBehaviour
{
    public Text title;
    public Text statistics;
    
    // Start is called before the first frame update
    void Start()
    {
        Player.calculate();

        title.text = "Jack Of All Trades";
        string temp = "" + Player.Career + "\n"
            + Player.Popularity + "\n"
            + Player.Health + "\n"
            + Player.LifeSkills + "\n"
            + Player.Morals;
        statistics.text = temp;
    }

    
}
