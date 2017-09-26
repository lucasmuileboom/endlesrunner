using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickUp : MonoBehaviour
{
    [SerializeField] private int amountOfScore;
    private score score;
    
    private void Start ()
    {
        score = GameObject.Find("score").GetComponent<score>();
    }
    public void getscore()
    {
        score.Score += amountOfScore;
        print("score");
        Destroy(gameObject);
    }
}
