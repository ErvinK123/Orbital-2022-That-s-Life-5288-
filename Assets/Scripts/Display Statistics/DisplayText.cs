using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class DisplayText : MonoBehaviour
{
    public TMP_InputField display;
    
    public void create()
    {
        Player.name = display.text; 
        PlayerPrefs.SetString("user_name", display.text);  
        PlayerPrefs.Save();
    }
   
}
