using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public int Score = 0;
    public bool SCORE = true;

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
        PauseScore();
	}
    public void StopsScore()
    {
        SCORE = false;
        print("Score: " + Score);

    }


    private void PauseScore()
    {
        if(Time.timeScale == 0)
        {
            StopScore();
        }
        else
        {
            Scoring();
        }

    }

    public void StopScore()
    {
        SCORE = false;
    }

    public void Scoring()
    {
        SCORE = true;
    }
}
