using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public struct PlayerState
{
	public Vector3 position;
	//public int animationStatement;
	public bool direction;

	public PlayerState(Vector3 position,/*int animationStatement*/ bool direction)
	{
		this.position = position;
		//this.animationStatement = animationStatement;
		this.direction = direction;
	}
}

public class Recorder : MonoBehaviour 
{

	[SerializeField] TimeController timeController;
	[SerializeField] Player player;

	Dictionary<int,PlayerState> states = new Dictionary<int, PlayerState> ();

	//Animator _animator;

	void Start ()
	{
		//_animator = GetComponent<Animator> ();
	
	}



	void Update()
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			isRecording = false;
			player.SetRecording(states);
			timeController.time = 0;
		}
	}


	bool isRecording = true;

	void FixedUpdate () 
	{
		if (isRecording) 
		{
			states.Add (timeController.time, new PlayerState (transform.position,
				/*_animator.GetCurrentAnimatorStateInfo(0).shortNameHash,*/ 
				transform.localScale.x > 0));
		}
		Debug.Log ("states: " + states.Count);
	
	}
}
