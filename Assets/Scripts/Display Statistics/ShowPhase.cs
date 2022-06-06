using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShowPhase : MonoBehaviour
{
    public Text phase;   // current phase of life
    public Text friends; // number of friends
    public Text enemies; // number of enemies

    // Function to convert friend/enemy count from int to string
    public static string intToString(int counter)
    {
        if (counter == 1)
        {
            return "1";
        }

        if (counter == 2)
        {
            return "2";
        }

        // Function returns "0" if counter == 0 or invalid counter number (<0 or >2)
        return "0";
    }


    // Start is called before the first frame update
    void Start()
    {
        phase.text = Player.age;
        friends.text = ShowPhase.intToString(Player.friends);
        enemies.text = ShowPhase.intToString(Player.enemies);
    }
}
