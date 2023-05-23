using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject jumpscareImage;
    public AudioSource jumpscareSound;
    
    //if player enters the trigger, show jumpscare image
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jumpscareImage.SetActive(true);
            jumpscareSound.Play();
            StartCoroutine(JumpscareEnd());
        }
    }

    IEnumerator JumpscareEnd()
    {
        yield return new WaitForSeconds(1f);
        jumpscareImage.SetActive(false);
    }
}
