using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlesystem_midieum : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    void Start()
    {

    }
    void Update()
    {
        if (GameManager.instance.coin_count > 100){
            if (!GameManager.instance.isGameover)
            {
                spawnRate = Random.Range(3f, 7f);
                if (Time.time > nextSpawn)
                {
                    nextSpawn = Time.time + spawnRate;
                    randX = Random.Range(-20f, 20f);
                    randY = Random.Range(-10f, 10f);
                    whereToSpawn = new Vector2(randX, randY);
                    Instantiate(enemy, whereToSpawn, Quaternion.identity);
                }
            }
        }
    }
}
