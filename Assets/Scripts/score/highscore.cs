using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highscore : MonoBehaviour
{
    score score;
    private int HighScore;

    private void Start ()
    {
        score = GetComponent<score>();
        HighScore = PlayerPrefs.GetInt("currentHighScore", 0);
        print("Highscore: " + HighScore);
    }
	private void Update ()
    {
        if (score.Score > HighScore)
        {
            HighScore = score.Score;
        }
	}
    public void savehighscore()
    {
        PlayerPrefs.SetInt("currentHighScore", HighScore);
        PlayerPrefs.Save();
    }
}
