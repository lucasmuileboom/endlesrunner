using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    private Playermovement Playermovement;
    private score score;
    private highscore highscore;
    private coin coin;

    private void Start()
    {
        coin = GameObject.Find("score").GetComponent<coin>();
        Playermovement = GetComponent<Playermovement>();
        score = GameObject.Find("score").GetComponent<score>();
        highscore = GameObject.Find("score").GetComponent<highscore>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {//gameover
            score.StopsScore();
            highscore.savehighscore();
            coin.savecoins();
        }
        if (collision.gameObject.tag == "floor")
        {
            Playermovement.isjump = false;
        }
        if (collision.gameObject.tag == "coins")
        {
            coin.getcoins();
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Playermovement.isjump = true;
        }
    }
}
