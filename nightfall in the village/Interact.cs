using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public bool inReach;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
        }
    }

    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            //changing scene to samplescene
            SceneManager.LoadScene("SampleScene");
        }
    }
}