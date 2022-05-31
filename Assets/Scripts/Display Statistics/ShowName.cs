using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShowName : MonoBehaviour
{   
    public Text d; 


    // Start is called before the first frame update
    void Start()
    {
        d.text = Player.name; 
    }

}
