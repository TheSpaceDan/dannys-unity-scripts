using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public AudioSource walkHard;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (GetComponent<FirstPersonController>().enableJump == true)
            {
                if (walkHard.isPlaying == false)
                {
                    walkHard.Play();
                }
            }
        }
        else
        {
            walkHard.Stop();
        }
    }
}

