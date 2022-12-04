using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private BoxCollider2D collider;
    private float groundSizeX;

    private void Start()
    {
        groundSizeX = collider.size.x;
    }

    private void Update()
    {
        Repeat();
    }

    private void Repeat()
    {
        if (transform.position.x <= -groundSizeX * 0.45f)
        {
            transform.position = 
            new Vector3(transform.position.x + 1.95f * groundSizeX * 0.45f, transform.position.y, 0);
        }
    }
}
