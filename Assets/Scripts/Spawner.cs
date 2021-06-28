using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;

    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float decreaseTime;
    private float minTime = 0.65f;

    void Update()
    {
        if (TimeBtwSpawn <= 0)
        {
            int i = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[i], transform.position, Quaternion.identity);
            TimeBtwSpawn = StartTimeBtwSpawn;
            if (StartTimeBtwSpawn > minTime)
            {
                StartTimeBtwSpawn -= decreaseTime;
            }

        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
