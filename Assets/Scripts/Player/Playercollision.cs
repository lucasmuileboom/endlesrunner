using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercollision : MonoBehaviour
{
    private Playermovement Playermovement;

    private score score;
    private highscore highscore;
    private coin coin;

    private void Start()
    {
        Playermovement = GetComponent<Playermovement>();
        coin = GameObject.Find("score").GetComponent<coin>();
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
            SceneManager.LoadScene(2);
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
}
