using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SplashTime : MonoBehaviour
{
    public Text timerText;
    public float totalTime = 3f;
    private float currentTime;

    private void Start()
    {
        currentTime = totalTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            //loading the menu scene after time
            SceneManager.LoadScene("Menu");
        }

    }
}