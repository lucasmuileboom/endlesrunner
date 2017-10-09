using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {
    public GameObject PauseMenuCanvas;
	// Use this for initialization

    public void Update()
    {
        PauseMenu();
    }

    public void Start()
    {
        PauseMenuCanvas.SetActive(false);
    }

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
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0;
          
        }else

       
        {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1;
            
        }




    }
    
}
