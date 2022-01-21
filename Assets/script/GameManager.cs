using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameover = false;
    public Text coinText;
    public Text score;
    public Text level;
    public GameObject gameoverUI;
    public GameObject gameoverUI1;
    public int coin_count;
    public GameObject enemy_square;
    public int allcoin;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null){
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }
    void Update() {
        if (coin_count >= 100)
        {
            level.text = "level: medium";
            if (coin_count >= 500)
            {
                level.text = "level: hard";
                if (coin_count >= 2000)
                {
                    level.text = "level: very hard";
                    if (coin_count >= 10000)
                    {
                        level.text = "level: hack";
                    }
                }
            }
        }
    }

    // Update is called once per frame
    public void AddCoin(int newcoin){
        coin_count += newcoin;
        coinText.text = coin_count.ToString();
    }
    public void OnplayerDead() {
        isGameover = true;
        allcoin += coin_count;
        score.text = "score: " + coin_count.ToString();
        gameoverUI.SetActive(true);
        gameoverUI1.SetActive(true);
        PlayerPrefs.SetInt("coin", coin_count);
        PlayerPrefs.Save();
    }
}
