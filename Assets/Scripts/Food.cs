using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private float rotateSpeed = 20.0f;
    private AudioSource biteSound;

    void Start()
    {
        biteSound = GameObject.Find("Mordida").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        biteSound.Play();

        //PlayerScore.pizzaScore += 1;

        Destroy(this.gameObject);
    }
}
