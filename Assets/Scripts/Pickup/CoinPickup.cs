using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] private int amountOfCoins;
    private coin coin;
    void Start ()
    {
        coin = GameObject.Find("score").GetComponent<coin>();
    }
    public void getcoins()
    {
        coin.coins += amountOfCoins;
        print("coins");
        Destroy(gameObject);
    }
}
