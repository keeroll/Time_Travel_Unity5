using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Mission : MonoBehaviour {

	public Text task;
	bool paused;

	void Start ()
	{
		task.GetComponent<Text> ();
		task.enabled = true;
		Time.timeScale = 0;
		paused = true;
	
	}
	

	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.F))
			{
				task.enabled = false;
				Time.timeScale = 1;
				paused = false;
			}
	
	}
}
