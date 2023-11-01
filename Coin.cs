using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private CharControl player;
    
    private void Start()
    {
        player = FindObjectOfType<CharControl>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        player.score++;
        Destroy(gameObject);
    }
}
