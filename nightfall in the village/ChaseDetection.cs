using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseDetection : MonoBehaviour
{
    public AudioSource music;
    
    //trigger detection for if player enters the collision
    private void OnTriggerEnter(Collider other)
    {
        //checking if player enters the collision
        if (other.CompareTag("Player"))
        {
            //playing music
            music.Play();
        }
        else
        {
            music.Stop();
        }

    }
}
