using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 0.02f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed);
        transform.Translate(0, speed, 0);
    }
}
