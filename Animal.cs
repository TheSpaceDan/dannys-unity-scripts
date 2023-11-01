using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animal : MonoBehaviour
{
    public Animator animator;
    public GameObject target;
    public float speed;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        //player
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("chase", true);
        }
        else
            animator.SetBool("chase", false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("chase", true);
            transform.LookAt(target.transform);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("chase", false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
