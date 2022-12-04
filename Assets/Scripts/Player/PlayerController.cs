using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float currentAngle;
    
    
    [SerializeField] private float maxAngle;
    [SerializeField] private float minAngle;
    
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
        Rotate();
    }

    private void Jump()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
        }
    }

    private void Rotate()
    {
        if (rb.velocity.y > 0 && currentAngle < maxAngle)
        {
            currentAngle = currentAngle + 4;
        }
        else if (rb.velocity.y < -3f && currentAngle > minAngle)
        {
            currentAngle = currentAngle - 2;
        }
        
        transform.rotation = Quaternion.Euler(0, 0, currentAngle);
    }
}
