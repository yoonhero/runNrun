using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battlesystem : MonoBehaviour
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
        if(!GameManager.instance.isGameover){
            if(GameManager.instance.coin_count >= 1){
                spawnRate = Random.Range(3f, 6f);
                if (GameManager.instance.coin_count >= 3)
                {
                    spawnRate = Random.Range(1f, 3f);
                } if (GameManager.instance.coin_count >= 10)
                {
                    spawnRate = Random.Range(1f, 1.5f);
                } if (GameManager.instance.coin_count >= 50)
                {
                    spawnRate = Random.Range(0.6f, 1.5f);
                } if (GameManager.instance.coin_count >= 200)
                {
                    spawnRate = Random.Range(0.3f, 1f);
                } if (GameManager.instance.coin_count >= 1000)
                {
                    spawnRate = Random.Range(0.2f, 0.5f);
                } if (GameManager.instance.coin_count >= 10000)
                {
                    spawnRate = Random.Range(0.1f, 0.2f);
                }
            }
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