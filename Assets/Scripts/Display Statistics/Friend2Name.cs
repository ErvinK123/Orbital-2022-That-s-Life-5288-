using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friend2Name : MonoBehaviour
{
    public Text Friend2;

    // Start is called before the first frame update
    void Start()
    {
        if ((Player.friend2 != null) && (Player.friend2 != ""))
        {
            Friend2.text = Player.friend2;
        } else
        {
            Friend2.text = FriendEnemy.friend2Arr[FriendEnemy.friend2Pointer];
        }
    }
}
