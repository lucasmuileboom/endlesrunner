using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {
    [SerializeField]
    private score Scores;

    public GameObject panel;
    public GameObject PauseMenuCanvas;
	// Use this for initialization

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Start()
    {
        panel.SetActive(false);
        PauseMenuCanvas.SetActive(false);
    }

	public void NewGameLoad () {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
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

    public void InstructionMenu()
    {
        panel.SetActive(true);
    }

    public void Back()
    {
        panel.SetActive(false);
    }

    public void InstructionScene()
    {
        SceneManager.LoadScene(3);
    }

    public void Resume()
    {
        PauseMenuCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {

        if (PauseMenuCanvas.gameObject.activeInHierarchy == false)
        {
            PauseMenuCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            
        }
        else
        {
            PauseMenuCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
           
        }

    }


}
