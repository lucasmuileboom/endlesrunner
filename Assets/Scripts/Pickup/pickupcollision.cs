using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupcollision : MonoBehaviour
{
    private ScorePickUp ScorePickUp;
    private CoinPickup CoinPickup;

    private void Start()
    {
        ScorePickUp = GetComponent<ScorePickUp>();
        CoinPickup = GetComponent<CoinPickup>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ScorePickUp != null)//pickup score
        {
            if (collision.gameObject.tag == "Player")
            {
                ScorePickUp.getscore();
            }
        }
        else if (CoinPickup != null)//pickup coins
        {
            if (collision.gameObject.tag == "Player")
            {
                CoinPickup.getcoins();
            }
        }
    }
}