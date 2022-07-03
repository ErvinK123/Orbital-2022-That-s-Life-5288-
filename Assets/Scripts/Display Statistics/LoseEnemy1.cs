using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseEnemy1 : MonoBehaviour
{
    public Text Enemy1;

    // Start is called before the first frame update
    void Start()
    {
        Enemy1.text = FriendEnemy.enemyArr[FriendEnemy.enemyPointer - 2];
    }
}
