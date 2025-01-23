using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyScript : MonoBehaviour
{
    public ElementType keyType;
    public bool fireKey;
    public bool waterKey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerElement playerElement = collision.GetComponent<PlayerElement>();
            if (playerElement != null)
            {
                switch (keyType)
                {
                    case ElementType.Fire:
                        if (playerElement.element == ElementType.Fire)
                        {
                            Destroy(gameObject);
                            Debug.Log("Fire player has the fire key!");
                            fireKey = true;
                        }
                        break;
                    case ElementType.Water:
                        if (playerElement.element == ElementType.Water)
                        {
                            Destroy(gameObject);
                            Debug.Log("Water player has the water key!");
                            waterKey = true;
                        }
                        break;
                       
                }
            }
        }
    }
}