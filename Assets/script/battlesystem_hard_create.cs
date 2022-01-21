using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battlesystem_hard_create : MonoBehaviour
{
    public GameObject enemy;
    public GameObject where;
    public Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public float time = 0.0f;

    void Start()
    {

    }
    void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            if (Time.time > nextSpawn)
            {
                whereToSpawn = where.transform.position;
                nextSpawn = Time.time + spawnRate;
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
            time += Time.deltaTime;
            /*if (time > 10)
            {
                Destroy(gameObject);
            }*/
        }
    }
}
