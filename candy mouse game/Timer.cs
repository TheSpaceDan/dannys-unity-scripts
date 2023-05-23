using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float totalTime = 30f;
    private float currentTime;

    private void Start()
    {
        currentTime = totalTime;
        UpdateTimerText();
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            // Time's up! Add any game-over logic here.
            // For example, show a game-over screen or restart the game.
            Debug.Log("Time's up!");
            
        }

        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = "Time: " + minutes.ToString("D2") + ":" + seconds.ToString("D2");
    }
}