using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
     [SerializeField] float rotationSpeed = 0.01f;
     [SerializeField] float speed = 0.01f;

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
}
