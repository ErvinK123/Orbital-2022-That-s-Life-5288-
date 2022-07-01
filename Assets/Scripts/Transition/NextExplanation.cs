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

    public void choice1f1()
    {
        if (Player.friend1 != null)
        {
            choice1();
        }
        else
        {
            Player.addFriend1();
            choice1();
        }

    }

    public void choice1f2()
    {
        if (Player.friend2 != null)
        {
            choice1();
        }
        else
        {
            Player.addFriend2();
            choice1();
        }

    }

    public void choice1lf1()
    {
        Player.loseFriend1();
        choice1();
    }

    public void choice1lf2()
    {
        Player.loseFriend2();
        choice1();
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

    public void choice1le()
    {
        Player.loseEnemy();
        choice1();
    }


    public void choice2()
    {
        //store choice 
        Player.storeChoice(2);

        //load new scene 
        string next = Player.getNextSceneName(2);
        SceneManager.LoadScene(next);
    }

    public void choice2f1()
    {
        if (Player.friend1 != null)
        {
            choice2();
        }
        else
        {
            Player.addFriend1();
            choice2();
        }
    }

    public void choice2f2()
    {
        if (Player.friend2 != null)
        {
            choice2();
        }
        else
        {
            Player.addFriend2();
            choice2();
        }

    }

    public void choice2lf1()
    {
        Player.loseFriend1();
        choice2();
    }

    public void choice2lf2()
    {
        Player.loseFriend2();
        choice2();
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

    public void choice2le()
    {
        Player.loseEnemy();
        choice2();
    }

    public void choice3()
    {
        //store choice 
        Player.storeChoice(3);

        //load new scene 
        string next = Player.getNextSceneName(3);
        SceneManager.LoadScene(next);
    }

    public void choice3f1()
    {
        if(Player.friend1 != null)
        {
            choice3();
        } else
        {
            Player.addFriend1();
            choice3();
        }
    }

    public void choice3f2()
    {
        if (Player.friend2 != null)
        {
            choice3();
        }
        else
        {
            Player.addFriend2();
            choice3();
        }

    }

    public void choice3lf1()
    {
        Player.loseFriend1();
        choice3();
    }

    public void choice3lf2()
    {
        Player.loseFriend2();
        choice3();
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

    public void choice3le()
    {
        Player.loseEnemy();
        choice3();
    }
}
