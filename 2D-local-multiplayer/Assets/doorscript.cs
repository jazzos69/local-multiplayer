using UnityEngine;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
    public string startscherm; // Naam van de volgende scene
    private bool isOpen = false;
    public KeyScript Keys;
    public bool firecheck = false;
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
        if (gameObject.CompareTag("exitdoor2") && Keys.fireKey == true)
        {
            firecheck = true;
        }
    }
}
