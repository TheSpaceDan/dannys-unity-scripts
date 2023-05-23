using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlashlightAdvanced : MonoBehaviour
{
    public Light light;
    
    public AudioSource flashON;
    public AudioSource flashOFF;

    private bool on;
    private bool off;

    void Start()
    {
        light = GetComponent<Light>();

        off = true;
        light.enabled = false;

    }
    
    void Update()
    {
        if(Input.GetButtonDown("flashlight") && off)
        {
            flashON.Play();
            light.enabled = true;
            on = true;
            off = false;
        }

        else if (Input.GetButtonDown("flashlight") && on)
        {
            flashOFF.Play();
            light.enabled = false;
            on = false;
            off = true;
        }
    }
}