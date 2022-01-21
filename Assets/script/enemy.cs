using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public int health = 1;
    public int coin = 1;

    void Update(){
        /*time += Time.deltaTime;
        if(destroy_time < time){
            Destroy(gameObject);
        }
        if(GameManager.instance.coin_count == 50){
            Destroy(gameObject);
            if (GameManager.instance.coin_count == 200)
            {
                Destroy(gameObject);
                if (GameManager.instance.coin_count == 1000)
                {
                    Destroy(gameObject);
                    if (GameManager.instance.coin_count == 10000)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }*/
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
                GameManager.instance.AddCoin(coin);
            }
        } else if (coll.gameObject.tag == "bullet2")
        {
            health--;
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
                GameManager.instance.AddCoin(coin);
            }
        } else if (coll.gameObject.tag == "bullet3")
        {
            health--;
            health--;
            health--;
            health--;
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
                GameManager.instance.AddCoin(coin);
            }
        }
    }
}
