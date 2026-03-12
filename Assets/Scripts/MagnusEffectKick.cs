using UnityEngine;

public class MagnusEffectKick : MonoBehaviour
{
    public Rigidbody rb;

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
        
    }
}
