using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;


public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("het spel sluit af, tot de volgende keer!");
    }
}