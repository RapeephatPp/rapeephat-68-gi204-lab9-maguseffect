using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    public Rigidbody rb;
    public int spinSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, spinSpeed, 0);
        }
        
    }
}
