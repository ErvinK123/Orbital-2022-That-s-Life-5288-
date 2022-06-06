using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerGenerator : MonoBehaviour
{
    public static void generateFair()
    {
        Player.generateFair(); 
    }

    public static void generateRandom()
    {
        Player.generateRandom(); 
    }
}
