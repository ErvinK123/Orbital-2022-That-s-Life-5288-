using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextExplanation : MonoBehaviour
{
    public void choice1()
    {
        //store choice 
        Player.storeChoice(1);

        //load new scene
        
        string next = Player.getNextSceneName(1);
        SceneManager.LoadScene(next);

    }


    public void choice2()
    {
        //store choice 
        Player.storeChoice(2);

        //load new scene 
        string next = Player.getNextSceneName(2);
        SceneManager.LoadScene(next);
    }

    public void choice3()
    {
        //store choice 
        Player.storeChoice(3);

        //load new scene 
        string next = Player.getNextSceneName(3);
        SceneManager.LoadScene(next);
    }

    //public void choice4()
    //{
    //    //store choice 
    //    Player.storeChoice(4);

    //    //load new scene 
    //    string next = Player.getNextSceneName(4);
    //    SceneManager.LoadScene(next);
    //}

    public void choice1f()
    {
        if (Player.isFriendLimit())
        {
            choice1();
        } else
        {
            Player.addFriend();
            choice1();
        }
        
    }


    public void choice2f()
    {
        if(Player.isFriendLimit())
        {
            choice2();
        } else
        {
            Player.addFriend();
            choice2();
        }
    }

    public void choice3f()
    {
        if(Player.isFriendLimit())
        {
            choice3();
        } else
        {
            Player.addFriend();
            choice3();
        }
    }

    public void choice1lf()
    {
        Player.loseFriend();
        choice1();
    }


    public void choice2lf()
    {
        Player.loseFriend();
        choice2();
    }

    public void choice3lf()
    {
        Player.loseFriend();
        choice3();
    }


    public void choice1e()
    {
        if (Player.isEnemyLimit())
        {
            choice1();
        }
        else
        {
            Player.addEnemy();
            choice1();
        }

    }


    public void choice2e()
    {
        if (Player.isEnemyLimit())
        {
            choice2();
        }
        else
        {
            Player.addEnemy();
            choice2();
        }
    }

    public void choice3e()
    {
        if (Player.isEnemyLimit())
        {
            choice3();
        }
        else
        {
            Player.addEnemy();
            choice3();
        }
    }

    public void choice1le()
    {
        Player.loseEnemy();
        choice1();

    }


    public void choice2le()
    {
        Player.loseEnemy();
        choice2();
    }

    public void choice3le()
    {
        Player.loseEnemy();
        choice3();
    }
}
