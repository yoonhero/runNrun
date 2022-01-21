using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinsManager : MonoBehaviour
{
    public static coinsManager instance;
    public Text coin;
    public int everycoin;
    void Start()
    {
        everycoin = PlayerPrefs.GetInt("coin", 0);
        coin.text = "coin: " + everycoin.ToString();
    }
}
