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

        title.text = Player.title;
        string temp = "" + Player.Career + "\n" + "\n"
            + Player.Popularity + "\n" + "\n"
            + Player.Health + "\n" + "\n"
            + Player.LifeSkills + "\n" + "\n"
            + Player.Morals;
        statistics.text = temp;
    }

    
}
