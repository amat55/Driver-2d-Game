using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f; // Delay before destroying the package
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1); 
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1); 
    private bool isTouched = false;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player hitted");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !isTouched)
        {
            Debug.Log("Player got the Package");
            isTouched = true;
            spriteRenderer.color = hasPackageColor; // Change color to indicate package is picked up
            Destroy(collision.gameObject, destroyDelay); // Destroy the package after 0.5 seconds
        }

        if (collision.tag == "Customer" && isTouched)
        {
            Debug.Log("Customer Touched");
            spriteRenderer.color = noPackageColor; // Change color back to indicate package is delivered
            isTouched = false; // Reset after delivering the package
        }
    }
}
