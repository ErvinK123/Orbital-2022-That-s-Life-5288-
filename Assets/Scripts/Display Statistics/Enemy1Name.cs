using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1Name : MonoBehaviour
{
    public Text Enemy1;

    // Start is called before the first frame update
    void Start()
    {
        if (Player.enemy == null)
        {
            Enemy1.text = FriendEnemy.enemyArr[FriendEnemy.enemyPointer];
        } else
        {
            Enemy1.text = Player.enemy;
        }
    }
}