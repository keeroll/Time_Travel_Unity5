using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GamePause : MonoBehaviour {

	bool paused;
	public Canvas canvas;
	Button menu;
	Button game;

	void Start () 
	{
	
		canvas.GetComponent<Canvas> ();
		canvas.enabled = false;
		menu.GetComponent<Button> ();
		game.GetComponent<Button> ();

	}
	

	void Update () 
	{
	
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			if (!paused)
			{

				Time.timeScale = 0;
				paused = true;
				canvas.enabled = true;


			}
			else
			{
				canvas.enabled = false;
				Time.timeScale = 1;
				paused = false;

			}
		}
	}

	public void ExitToMenu()
	{
		Application.LoadLevel(0);
	}

	public void ReturnToGame()
	{
		canvas.enabled = false;
		Time.timeScale = 1;
		paused = false;
	}
}
