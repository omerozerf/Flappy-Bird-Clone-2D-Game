using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    
}
