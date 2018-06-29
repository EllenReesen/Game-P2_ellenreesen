using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool PauseGame = false;

	public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			if (PauseGame) {
				Resume ();
			} else {
				Pause ();

			}	
		}
	}
	
	public void Resume ()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		PauseGame = false;
	}

	void Pause()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		PauseGame = true;
	}

	public void DoRestart()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		Debug.Log("Resarting...");

	}
	public void LoadMenu(string MenuScene)
	{
		SceneManager.LoadScene("MenuScene");
	}

	public void QuitGame ()
	{
		Debug.Log("Quitting Game...");
		Application.Quit();
	}

}
