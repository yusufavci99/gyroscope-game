using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    void Update()
    {
        
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 gyro = new Vector3(Input.acceleration.x, 0.0f, Input.acceleration.y);
        rb.AddForce(gyro * speed);
    }
}
