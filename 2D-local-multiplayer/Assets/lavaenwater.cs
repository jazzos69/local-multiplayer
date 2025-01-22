using UnityEngine;


public class lavaenwater : MonoBehaviour
{
    // waar spawn points
    public Transform firePlayerSpawnPoint;
    public Transform waterPlayerSpawnPoint;

    void Start()
    {
        waterPlayerSpawnPoint.position = new Vector3(6, -4, 0);  
        firePlayerSpawnPoint.position = new Vector3(-6, -4, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // haalt player element voor collision
            PlayerElement playerElement = collision.GetComponent<PlayerElement>();

            if (playerElement != null)
            {
                if (gameObject.CompareTag("lava") && playerElement.element == ElementType.Water)
                {
                    // Water player raakt lava
                    Debug.Log("Water player died in lava!");
                    RespawnPlayer(collision.gameObject, waterPlayerSpawnPoint);
                }
                else if (gameObject.CompareTag("water") && playerElement.element == ElementType.Fire)
                {
                    // Fire player raakt water
                    Debug.Log("Fire player died in water!");
                    RespawnPlayer(collision.gameObject, firePlayerSpawnPoint);
                }
            }
        }
    }

    private void RespawnPlayer(GameObject player, Transform spawnPoint)
    {
        // respawn point 
        player.transform.position = spawnPoint.position;
    }
}
