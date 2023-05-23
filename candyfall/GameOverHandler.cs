using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    public void HandleGameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0;
    }
}