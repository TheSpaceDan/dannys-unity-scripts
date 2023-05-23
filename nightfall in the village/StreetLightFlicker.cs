using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLightFlicker : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        //flickering the light
        GetComponent<Light>().intensity = Random.Range(0.5f, 1.5f);
        
    }
}
