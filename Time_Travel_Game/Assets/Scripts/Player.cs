using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	[SerializeField] TimeController timeController;

	Dictionary<int,PlayerState> records;

	//Animator _animator;
	Rigidbody _rigidBody;

	void Start ()
	{
		//_animator = GetComponent<Animator> ();
		_rigidBody = GetComponent<Rigidbody>();

	}

	public void StartRecording (Dictionary<int, PlayerState> recording)
	{
		this.records = new Dictionary<int, PlayerState> (recording);
		isPlaying = true;
		_rigidBody.isKinematic = true;

	}

	void Update()
	{
		
	}


	bool isPlaying = false;
	void FixedUpdate ()
	{
		if (isPlaying) 
		{
			if (records.ContainsKey (timeController.time))
			{
				PlayState(records [timeController.time]);
			}
		}
	}

	void PlayState(PlayerState playerState)
	{
		transform.position = playerState.position;
		//_animator.Play(playerState.animationStatement);
		Vector3 localScale = transform.localScale;
		localScale.x = playerState.direction ? Mathf.Abs (localScale.x) : -Mathf.Abs (localScale.x);
	}
}
