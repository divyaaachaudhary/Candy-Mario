using UnityEngine;

public class Coin : MonoBehaviour
{
    // Static variable to track total coins collected
    public static int coinCount = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coinCount++; // Increment the coin counter
            Debug.Log("Coins Collected: " + coinCount); // Optional: show count in console
            Destroy(gameObject); // Destroy the coin on collision
        }
    }
}

