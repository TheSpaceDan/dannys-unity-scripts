using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScreen : MonoBehaviour
{
    private GameObject player;
    public GameObject startingScreen;

    public float waitTime;
    
    public FirstPersonController firstPersonController;
    
    void Start()
    {
        //hiding the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        startingScreen.SetActive(true);
        player = GameObject.FindWithTag("Player");
        player.GetComponent<FirstPersonController>().enabled = false;

        StartCoroutine(Starting());
    }

    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        //startingScreen.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
        

    }
}