using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private Queue<GameObject> pooledObstacles;
    [SerializeField] private int poolSize;
    [SerializeField] private GameObject obstaclePrefab;

    private void Awake()
    {
        pooledObstacles = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(obstaclePrefab);
            obj.SetActive(false);
            pooledObstacles.Enqueue(obj);
        }
    }

    public GameObject GetObstacle()
    {
        GameObject obj = pooledObstacles.Dequeue();
        obj.SetActive(true);
        pooledObstacles.Enqueue(obj);
        return obj;
    }
}
