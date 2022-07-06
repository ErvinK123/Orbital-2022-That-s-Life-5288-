using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friend1Name : MonoBehaviour
{
    public Text Friend1;

    // Start is called before the first frame update
    void Start()
    {
        if ((Player.friend1 != null) && (Player.friend1 != ""))
        {
            Friend1.text = Player.friend1;
        } else
        {
            Friend1.text = FriendEnemy.friend1Arr[FriendEnemy.friend1Pointer];
        }
    }
}
