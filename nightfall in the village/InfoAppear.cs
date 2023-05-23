using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAppear : MonoBehaviour
{
    public GameObject infoText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoText.SetActive(true);
        }
    }
    
}
