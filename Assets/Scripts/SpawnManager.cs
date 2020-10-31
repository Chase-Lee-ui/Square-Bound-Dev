using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject asteroids;
    public float startDelay, spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAsteroids", startDelay, spawnInterval);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAsteroids()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-11.19f, 12.98f), 12.6f);
        Instantiate(asteroids, spawnPos, asteroids.transform.rotation);
    }
}
