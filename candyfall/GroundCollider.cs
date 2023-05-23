using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            Destroy(collision.gameObject);
            FindObjectOfType<GameOverHandler>().HandleGameOver();
            Debug.Log("Candy touched the ground!");
        }
    }
}