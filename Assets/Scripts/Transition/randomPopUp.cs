using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomPopUp : MonoBehaviour
{
    [SerializeField] private GameObject gameObject;

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void open()
    {
        gameObject.SetActive(true);
    }

    public void close()
    {
        gameObject.SetActive(false);
    }
}
