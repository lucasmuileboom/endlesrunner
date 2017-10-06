using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {

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
}
