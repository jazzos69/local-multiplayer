using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public bool firecheck;
    public bool watercheck;

    public void Update()
    {
        if (firecheck && watercheck)
        {
            SceneManager.LoadScene("startscherm");
            Debug.Log("Player entered the door!");
        }
    }
}
