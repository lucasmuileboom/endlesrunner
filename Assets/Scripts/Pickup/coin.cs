using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public int coins;
    [SerializeField] private Text coinText;
    private void Start ()
    {
        coins = PlayerPrefs.GetInt("currentcoins", 0);
        coinText.text = "coins: " + coins;
    }
    public void savecoins()
    {
        PlayerPrefs.SetInt("currentcoins", coins);
        PlayerPrefs.Save();
    }
    public void getcoins()
    {
        coins++;
        coinText.text = "coins: " + coins;
    }
}
