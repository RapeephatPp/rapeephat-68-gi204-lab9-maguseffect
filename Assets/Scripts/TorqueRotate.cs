using UnityEngine;

public class TorqueRotate : MonoBehaviour
{
    public Rigidbody rb;
    public int rotateSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(0,0, rotateSpeed);
        }
    }
}
