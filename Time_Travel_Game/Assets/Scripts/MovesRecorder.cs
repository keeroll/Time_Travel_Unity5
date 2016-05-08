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

public class MovesRecorder : MonoBehaviour 
{

	[SerializeField] TimeController timeController;
	[SerializeField] Player player;

	Dictionary<int,PlayerState> playerCoordinates = new Dictionary<int, PlayerState> ();

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
			player.StartRecording(playerCoordinates);
			timeController.time = 0;
		}
	}


	bool isRecording = true;

	void FixedUpdate () 
	{
		if (isRecording) 
		{
			playerCoordinates.Add (timeController.time, new PlayerState (transform.position,/*_animator.GetCurrentAnimatorStateInfo(0).shortNameHash,*/ transform.localScale.x > 0));
		}

	}
}
