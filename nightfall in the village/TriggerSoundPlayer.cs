using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundPlayer : MonoBehaviour
{
    public AudioSource triggerSound;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //playing sound on trigger enter
        triggerSound.Play();
    }
}
