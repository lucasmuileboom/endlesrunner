using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {
    public GameObject PauseMenuCanvas;
	// Use this for initialization
	public void NewGameLoad () {
        SceneManager.LoadScene(1);
	}

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadScenes()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&Time.timeScale ==1)
        {
            Time.timeScale = 0;
            PauseMenuCanvas.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            PauseMenuCanvas.gameObject.SetActive(false);
        }
       
    }
}
