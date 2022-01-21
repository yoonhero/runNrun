using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunChange : MonoBehaviour
{
    public GameObject select;
    public int product_num;
    public void gunChanged(){
        
        if (product_num == 2)
        {
            if (PlayerPrefs.GetInt("buying2", 0) == 1)
            {
                PlayerPrefs.SetInt("gun_num", product_num);
                Debug.Log("success");
                select.gameObject.SetActive(true);
            }
            else
            {
                Debug.Log("not buying yet");
                select.gameObject.SetActive(false);
            }
        }
        else if (product_num == 3)
        {
            if (PlayerPrefs.GetInt("buying3", 0) == 1)
            {
                PlayerPrefs.SetInt("gun_num", product_num);
                Debug.Log("success");
                select.gameObject.SetActive(true);
            }
            else
            {
                Debug.Log("not buying yet");
                select.gameObject.SetActive(false);
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("buying1", 0) == 1)
            {
                PlayerPrefs.SetInt("gun_num", product_num);
                Debug.Log("success");
                select.gameObject.SetActive(true);
            }
            else
            {
                Debug.Log("not buying yet");
                select.gameObject.SetActive(false);
            }
        }
    }
}
