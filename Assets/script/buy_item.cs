using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buy_item : MonoBehaviour
{
    public int product_num;
    public int coin;
    public Text coins;
    public GameObject buy_button;
    public GameObject sold;
    public GameObject nomoney;
    public int price;
    void Start(){
        coin = PlayerPrefs.GetInt("coin", 0);
        PlayerPrefs.DeleteKey("buying1");
        PlayerPrefs.DeleteKey("buying2");
        PlayerPrefs.DeleteKey("buying3");
    }
    public void buy(){
        if (price <= coin){
            coin -= price;
            coins.text = "coin: " + coin.ToString();
            nomoney.gameObject.SetActive(false);
            buy_button.gameObject.SetActive(false);
            sold.gameObject.SetActive(true);
            if (product_num == 2)
            {
                PlayerPrefs.SetInt("buying2", 1);
            } else if (product_num == 3)
            {
                PlayerPrefs.SetInt("buying3", 1);
            }else{
                PlayerPrefs.SetInt("buying1", 1);
            }
        } else {
            Debug.Log("no money");
            nomoney.gameObject.SetActive(true);
        }
    }
}
