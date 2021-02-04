﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawnerScript : MonoBehaviour
{

    public GameObject apple;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range((float)-60f, 165f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(apple, whereToSpawn, Quaternion.identity);

        }
        
    }
}
