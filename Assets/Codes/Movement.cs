using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 0.01f;
    [SerializeField] float speed = 0.01f;
    [SerializeField] float boostSpeed = 0.02f; // Speed when boosting
    [SerializeField] float boostDuration = 2f; // Duration of the boost effect
    [SerializeField] float slowSpeed = 0.005f; // Speed when slowing down

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * rotationSpeed;
        float verticalInput = Input.GetAxis("Vertical") * speed;
        transform.Rotate(0, 0, -horizontalInput * Time.deltaTime);
        transform.Translate(0, verticalInput * Time.deltaTime, 0);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        speed = slowSpeed; // Slow down on collision
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BoostSpeed")
        {
            Debug.Log("Boost Speed Triggered");
            speed = boostSpeed; // Boost speed when entering the trigger
        }
    }

}
