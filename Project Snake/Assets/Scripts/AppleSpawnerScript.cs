using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawnerScript : MonoBehaviour
{

    public GameObject apple;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Nextspawn location
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range((float)-60f, 165f);
            randY = Random.Range((float)-40f, 100f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(apple, whereToSpawn, Quaternion.identity);

        }
        
    }
}
