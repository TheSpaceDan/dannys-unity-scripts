using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject loading;
    public GameObject logo;
    public float waitTime;
    public AudioSource buttonSound;

    void Start()
    {
        logo.SetActive(true);

        StartCoroutine(Starting());
    }

    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        logo.SetActive(false);
        mainMenu.SetActive(true);
        loading.SetActive(false);

    }

    public void StartButton()
    {
        loading.SetActive(true);
        mainMenu.SetActive(false);
        buttonSound.Play();
        SceneManager.LoadScene("Demo");
    }
}