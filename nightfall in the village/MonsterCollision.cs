using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollision : MonoBehaviour
{
    public GameObject jumpscareImage;
    public AudioSource jumpscareSound;
    public GameObject Text;
    public GameObject player;
    public GameObject monster;
    public GameObject camera;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {
            jumpscareImage.SetActive(true);
            player.SetActive(false);
            monster.SetActive(false);
            camera.SetActive(true);
            Text.SetActive(true);
            jumpscareSound.Play();
        }
    }
    
}