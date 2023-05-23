using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject startScreen;
    public AudioSource sound;
    public GameObject monster;
    public GameObject Objective;
    
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(CutsceneStart());
    }
    
    IEnumerator CutsceneStart()
    {
        startScreen.SetActive(false);
        sound.Play();
        yield return new WaitForSeconds(5.5f);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
        Objective.SetActive(true);
        Destroy(monster);
        
    }
}
