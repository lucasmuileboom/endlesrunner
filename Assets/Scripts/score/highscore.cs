using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highscore : MonoBehaviour
{
    [SerializeField] private Text HighScoreText;
    private score score;
    private int HighScore;    

    private void Start ()
    {
        score = GetComponent<score>();
        HighScore = PlayerPrefs.GetInt("currentHighScore", 0);
        HighScoreText.text = "Highscore: " + HighScore;
    }
	private void Update ()
    {
        if (score.Score > HighScore)
        {
            HighScore = score.Score;
            HighScoreText.text = "Highscore: " + HighScore;
        }
	}
    public void savehighscore()
    {
        PlayerPrefs.SetInt("currentHighScore", HighScore);
        PlayerPrefs.Save();
    }
}
