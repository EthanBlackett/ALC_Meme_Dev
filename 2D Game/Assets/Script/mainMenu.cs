using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    public int levelToLoad;


	// Use this for initialization
	public void LoadLevel () {
        SceneManager.LoadScene(levelToLoad);
	}
	
	// Update is called once per frame
	public void levelExit () {
        Application.Quit();
	}
}
