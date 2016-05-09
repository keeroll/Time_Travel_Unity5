using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	Button startText;
	Button exitText;

	void Start () 
	{
		startText.GetComponent<Button> ();
		exitText.GetComponent<Button> ();
	}
	

	public void StartGame()
	{
		Application.LoadLevel (1);
	}
	public void ExitGame()
	{
		Application.Quit ();
	}
}
