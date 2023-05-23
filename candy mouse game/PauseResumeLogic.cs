using UnityEngine;

public class PauseResumeLogic : MonoBehaviour
{
    public static PauseResumeLogic instance;

    public GameObject playerObject;
    public float totalTime = 30f;
    private float currentTime;
    private bool isPaused = false;
    public GameObject menu;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    private void Start()
    {
        currentTime = totalTime;
        Time.timeScale = 1f; // Ensure time scale is set to normal on start
    }

    private void Update()
    {
        if (!isPaused)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                // Time's up! Pause the game
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        
        playerObject.GetComponent<MouseMovement>().enabled = false;
        menu.SetActive(true);
        
    }

    public void RestartGame()
    {
        isPaused = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
    
    public void GoToHome()
    {
        // Restart the game by reloading the current scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}