using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shooting_hard : MonoBehaviour
{
    public float speed;
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public Transform firePoint5;
    public Transform firePoint6;
    public Transform firePoint7;
    public Transform firePoint8;
    public Transform firePoint9;
    public float bulletForce = 20f;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;

    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            if (timeBtwShots <= 0)
            {
                GameObject bullet = Instantiate(projectile, firePoint1.position, firePoint1.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);
                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
    }
}
