using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToMenu : MonoBehaviour {

	public void Menu()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 0);
	}

	public void Quitting()
	{
		Debug.Log("Quitting");
		Application.Quit();
	}



}
