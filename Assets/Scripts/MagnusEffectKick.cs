using System;
using UnityEngine;

public class MagnusEffectKick : MonoBehaviour
{
    public Rigidbody rb;
    private bool isShot = false;
    
    public int kickForce = 2;
    public int spinAmount = 2;
    public float magnusStrengh = 0.5f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !isShot)
        {
            rb.AddForce(Vector3.left * kickForce, ForceMode.Impulse);
            
            rb.AddTorque(Vector3.up * spinAmount);
            isShot = true;
        }
    }

    private void FixedUpdate()
    {
        if (!isShot) return;

        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 magnusForce = magnusStrengh * Vector3.Cross(spin, velocity);
        
        rb.AddForce(magnusForce);
    }
}
