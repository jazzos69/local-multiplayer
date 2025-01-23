using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public bool firecheck;
    public bool watercheck;

    public KeyScript keyScript;
    private void Start()
    {
        keyScript = FindObjectOfType<KeyScript>();
    }

    public void Update()
    {
        if (keyScript.fireKey && keyScript.waterKey)
        {
            SceneManager.LoadScene("startscherm");
            Debug.Log("Player entered the door!");
        }
    }
}
