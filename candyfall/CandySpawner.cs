using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject candyPrefab;
    public Transform[] spawnPoints;
    public float minSpawnInterval = 0.5f;
    public float maxSpawnInterval = 1.5f;
    public float minSpeed = 1f;
    public float maxSpeed = 3f;

    private float nextSpawnTime;

    private void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnCandy();
            nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    private void SpawnCandy()
    {
        var spawnIndex = Random.Range(0, spawnPoints.Length);
        var spawnPoint = spawnPoints[spawnIndex];
        var candy = Instantiate(candyPrefab, spawnPoint.position, Quaternion.identity);
        var rigidbody = candy.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0f, -Random.Range(minSpeed, maxSpeed));
    }
}