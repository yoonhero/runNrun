using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player_Movement : MonoBehaviour {

	public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;
    public GameObject gun3_1;
	public float moveSpeed = 5f;
	public int health = 10;

	float timer = 0;

	float coin_timer = 0;
	int waitingTime = 1;

	float dashTimer = 0;
	float dashTime = 0.3f;
	bool dash = true;

	public Rigidbody2D rb;
	public Camera cam;

	public healthbar healthBar;

	Vector2 movement;
	Vector2 mousePos;
	// Update is called once per frame
	void Start()
	{
		healthBar.SetMaxHealth(health);
		if(PlayerPrefs.GetInt("gun_num", 0) == 2){
			gun2.gameObject.SetActive(true);
		} else if (PlayerPrefs.GetInt("gun_num", 0) == 3)
        {
            gun3.gameObject.SetActive(true);
            gun3_1.gameObject.SetActive(true);
        }else{
			gun1.gameObject.SetActive(true);
		} //GameManager.instance.AddCoin(coin);
	}
	void Update () {
		// input
		movement.x = Input.GetAxisRaw ("Horizontal");
		movement.y = Input.GetAxisRaw ("Vertical");

		mousePos = cam.ScreenToWorldPoint (Input.mousePosition);

		timer += Time.fixedDeltaTime;
		coin_timer += Time.fixedDeltaTime;
		if (timer > waitingTime) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				// Instantiate (dashEffect, transform.position, Quaternion.identity)
				moveSpeed = 20f;
				dash = false;
			}
			if (dash == false) {
				dashTimer += Time.fixedDeltaTime;

				if (dashTimer > dashTime) {
					timer = 0;
					dashTimer = 0;
					moveSpeed = 5;
					dash = true;
				}
			}
		}
		if (coin_timer > 1){
			GameManager.instance.AddCoin(1);
			coin_timer = 0;
		}
	}

	void FixedUpdate () {
		// movement
		rb.MovePosition (rb.position + movement * moveSpeed * Time.fixedDeltaTime);

		Vector2 lookDir = mousePos - rb.position;
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
		rb.rotation = angle;
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
        {
            health--;
			healthBar.SetHealth(health);
            if (health <= 0)
            {
                Destroy(gameObject);
				gameover();
            }
        }
		if (coll.gameObject.tag == "potion")
		{
			health += 3;
            healthBar.SetHealth(health);
		}
        if (coll.gameObject.tag == "enemy2")
        {
            health--;
            health--;
            healthBar.SetHealth(health);
        }
    }
	void gameover()
	{
		GameManager.instance.OnplayerDead();
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}