using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class ObstacleSpawner : MonoBehaviour
    {

        [SerializeField] private GameObject obstacle;
        [SerializeField] private float waitTime;
        [SerializeField] private ObjectPool pool;
        [SerializeField] private float upLimitY;
        [SerializeField] private float lowLimitY;
        
        
        

        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }


        private IEnumerator SpawnObstacle()
        {
            while (true)
            {
                yield return new WaitForSeconds(waitTime);
                GameObject obj = pool.GetObstacle();
                obj.transform.position = new Vector3(transform.position.x, RandomSpawnPos(), 0);
            }
            
        }

        private float RandomSpawnPos()
        {
            float randomPosY = Random.Range(lowLimitY, upLimitY);
            return randomPosY;
        }
    }
    
}