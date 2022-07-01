using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAge : MonoBehaviour
{
    public Text DisplayAge;


    // Start is called before the first frame update
    void Start()
    {
        DisplayAge.text = Player.displayAge();
    }
}
