using UnityEngine;

public class Candy : MonoBehaviour
{
    public int scoreValue = 10;
    public GameObject candyPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.AddScore(scoreValue);
            
            SpawnNewCandy();

            Destroy(gameObject);
        }
    }

    private void SpawnNewCandy()
    {
        // Instantiate a new candy at a random position within the screen boundaries
        Vector3 randomPosition = GetRandomScreenPosition();
        Instantiate(candyPrefab, randomPosition, Quaternion.identity);
    }

    private Vector3 GetRandomScreenPosition()
    {
        float screenLeft = Camera.main.ScreenToWorldPoint(Vector3.zero).x;
        float screenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f)).x;
        float screenBottom = Camera.main.ScreenToWorldPoint(Vector3.zero).y;
        float screenTop = Camera.main.ScreenToWorldPoint(new Vector3(0f, Screen.height)).y;

        float randomX = Random.Range(screenLeft, screenRight);
        float randomY = Random.Range(screenBottom, screenTop);

        return new Vector3(randomX, randomY, 0f);
    }
}