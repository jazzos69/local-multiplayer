using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyscript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            // haalt player element voor collision
            PlayerElement playerElement = collision.GetComponent<PlayerElement>();

            if (playerElement != null)
            {
                if (gameObject.CompareTag("firekey") && playerElement.element == ElementType.Fire)
                {
                    Destroy(gameObject);
                    Debug.Log("fireplayer has his key");
                    
                }
                else if (gameObject.CompareTag("waterkey") && playerElement.element == ElementType.Water)
                {
                    Destroy(gameObject);
                    Debug.Log("waterplayer has his key");
                    
                }
            }
        }
    }
}
