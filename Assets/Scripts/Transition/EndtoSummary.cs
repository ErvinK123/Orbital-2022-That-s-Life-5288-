using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndtoSummary : MonoBehaviour
{
    public Animator SceneTransition;

    IEnumerator LoadLevel()
    {
        SceneTransition.SetTrigger("Start");

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("Summary");
    }

    public void next()
    {
        StartCoroutine("LoadLevel");
        
    }
}
