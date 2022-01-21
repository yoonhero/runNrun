using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint3_1;
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot(){
        if (PlayerPrefs.GetInt("gun_num", 0) == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);
        }
        else if (PlayerPrefs.GetInt("gun_num", 0) == 2)
        {
            GameObject bullet = Instantiate(bulletPrefab2, firePoint2.position, firePoint2.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
        }
        else if (PlayerPrefs.GetInt("gun_num", 0) == 3)
        {
            GameObject bullet = Instantiate(bulletPrefab3, firePoint3.position, firePoint3.rotation);
            GameObject bullet1 = Instantiate(bulletPrefab3, firePoint3_1.position, firePoint3_1.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);
            rb1.AddForce(firePoint3_1.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
