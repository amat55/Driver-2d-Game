using UnityEngine;

public class Collision : MonoBehaviour
{
    private bool isTouched = false; 

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player hitted");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Player got the Package");
            isTouched = true;
        }

        if (collision.tag == "Customer" && isTouched)
        {
            Debug.Log("Customer Touched");
            isTouched = false; // Reset after delivering the package
        }
    }
}
