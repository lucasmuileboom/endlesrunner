using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    Playermovement Playermovement;
    score score;
    highscore highscore;

    private void Start()
    {
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
        }
        if (collision.gameObject.tag == "floor")
        {
            Playermovement.isjump = false;
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
