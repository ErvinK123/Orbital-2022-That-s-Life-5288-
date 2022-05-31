using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShowPhase : MonoBehaviour
{
    public Text phase; 
    // Start is called before the first frame update
    void Start()
    {
        phase.text = Player.age; 
    }
}
