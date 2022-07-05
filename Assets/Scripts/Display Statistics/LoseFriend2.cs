using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseFriend2 : MonoBehaviour
{
    public Text Friend2;

    // Start is called before the first frame update
    void Start()
    {
        Friend2.text = FriendEnemy.friend2Arr[FriendEnemy.friend2Pointer - 2];
    }
}