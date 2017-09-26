using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int Score = 0;
    private bool SCORE = true;

	private void Update ()
    {
        if (SCORE)
        {
            Score++;
           // 
        }  
	}
    public void StopsScore()
    {
        SCORE = false;
        print("Score: " + Score);
    }
}
