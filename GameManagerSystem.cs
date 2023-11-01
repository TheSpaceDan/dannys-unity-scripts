using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject[] spawnPoints;

    void Start()
    {
        int playerRandom = Random.Range(0, spawnPoints.Length);
        Instantiate(player, spawnPoints[playerRandom].transform.position, Quaternion.identity);
    }

}