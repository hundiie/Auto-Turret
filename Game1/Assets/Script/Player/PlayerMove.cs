using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody rb;

    public float MoveSpeed;
    public bool RUN = false;
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
        Debug.Log("PlayerMove Start");
        
    }
    void Update()
    {
        if (RUN)
        {
            rb.velocity = new Vector3(_input.X * MoveSpeed, 0f, _input.Y * MoveSpeed);
        }
        else
        {
            rb.AddForce(-_input.X * MoveSpeed, 0f,-_input.Y * MoveSpeed);
        }
    }
}
