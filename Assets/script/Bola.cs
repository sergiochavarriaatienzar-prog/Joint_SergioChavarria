using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    //Que la pelota vaya hacia la puerta
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;
    }
}
