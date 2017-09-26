using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public int Score = 0;
    private bool SCORE = true;

    private void Start()
    {
        scoreText.text = "Score: " + Score;
    }
    private void Update ()
    {
        if (SCORE)
        {
            Score++;
            scoreText.text = "Score: " + Score;
        }  
	}
    public void StopsScore()
    {
        SCORE = false;
        print("Score: " + Score);

    }
}
