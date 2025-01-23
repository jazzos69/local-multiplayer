using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorscript2 : MonoBehaviour
{
    public string startscherm; // Naam van de volgende scene
    private bool isOpen = false;
    public KeyScript Keys;
    public bool watercheck = false;
    public void Open()
    {
        isOpen = true;
        Debug.Log("Door Opened!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOpen && other.CompareTag("Player"))
        {
            SceneManager.LoadScene(startscherm);
            Debug.Log("Player entered the door!");
        }
        if (gameObject.CompareTag("exitdoor") && Keys.fireKey == true)
        {
            watercheck = true;
        }
    }
}
