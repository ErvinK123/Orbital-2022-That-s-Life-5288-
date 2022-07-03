using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseFriend1 : MonoBehaviour
{
    public Text Friend1;

    // Start is called before the first frame update
    void Start()
    {
        Friend1.text = FriendEnemy.friend1Arr[FriendEnemy.friend1Pointer - 2];
    }
}
