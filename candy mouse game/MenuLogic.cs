using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour
{
    //logic for start button click
    public void StartGame()
    {
        //loading the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    
    //logic for close button click
    public void CloseGame()
    {
        //closing the game
        Application.Quit();
    }
}
