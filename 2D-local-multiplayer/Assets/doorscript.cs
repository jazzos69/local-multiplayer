using UnityEngine;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
    public string nextSceneName; // Naam van de volgende scene
    private bool isOpen = false;

    public void Open()
    {
        isOpen = true;
        Debug.Log("Door Opened!");
        //Hier kun je eventueel een animatie afspelen voor het openen van de deur.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOpen && other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
