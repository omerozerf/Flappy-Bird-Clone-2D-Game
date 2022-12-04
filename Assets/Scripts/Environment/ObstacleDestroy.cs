using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
    [SerializeField] private float xRange;
    
    private void Update()
    {
        DestroyObj();
    }

    private void DestroyObj()
    {
        if (transform.position.x < xRange)
        {
            gameObject.SetActive(false);
        }
    }
}
